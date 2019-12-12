using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BraintreeHttp;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using PayPal.v1.Payments;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class PaypalController : Controller
    {
        public readonly TechWorld_2Context db;
        public PaypalController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }

                return data;
            }
        }
        public async Task<IActionResult> Checkout()
        {
            //SandboxEnvironment(clientId, clientSerect)
            var environment = new SandboxEnvironment("AW0XNlAAqYLVMTbaBJVpAz_DFp2TrHMQgAmZ5WXDPt9Hoyt4Jrrb1ZpdvpI70CIqetpb3yHYV23Z9vsS", "EKqZen_z_GAihIxYgBDxy8mvu2Cola9Pdq09v38SSWn05gaAXgmlPy7H-UK7bhL9tW8CSCrVYM5A7WWv");
            var client = new PayPalHttpClient(environment);

            //Đọc thông tin đơn hàng từ Session
            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            var tongTien = Cart.Sum(p => p.ThanhTien);
            foreach (var item in Cart)
            {
                itemList.Items.Add(new Item()
                {
                    Name = item.TenHh,
                    Currency = "USD",
                    Price = item.GiaBan.ToString(),
                    Quantity = item.SoLuong.ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
            }

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = tongTien.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = tongTien.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = "Shop online technology products",
                        InvoiceNumber = DateTime.Now.Ticks.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://techworld.azurewebsites.net/Paypal/Fail",
                    ReturnUrl = "https://techworld.azurewebsites.net/Paypal/Success"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            KhachHang kh = HttpContext.Session.Get<KhachHang>("Username");
            HoaDon hd = new HoaDon
            {
                MaKh = kh.MaKh,
                HoTen = kh.HoTen,
                DiaChi = kh.DiaChi,
                NgayDat = DateTime.Now,
                // GhiChu = ghichu,
                SdtNguoinhan = kh.DienThoai,
                MaTrangThai = 0,
                PhuongThucThanhToan = 1,
                TinhTrangThanhToan = 1,
                PhiVanChuyen = 0

            };
            db.HoaDon.Add(hd);
            double tongtien = 0;
            double tonghoadon = 0;

            foreach (var i in Cart)
            {
                tongtien = tongtien + i.ThanhTien;
                HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == i.MaHh);

                ChiTietHd cthd = new ChiTietHd
                {
                    MaHd = hd.MaHd,
                    MaHh = i.MaHh,
                    DonGia = hh.DonGia,
                    GiamGia = hh.GiamGia,
                    SoLuong = i.SoLuong
                };
                db.ChiTietHd.Add(cthd);
                db.SaveChanges();

            }
            tonghoadon = tongtien + 0;
            hd.TongTienHang = tongtien;
            hd.TongThucThu = tonghoadon;
            db.SaveChanges();
            HttpContext.Session.Remove("GioHang");

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);

            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                return RedirectToAction("Fail");
            }

            //return View();
        }

        public IActionResult Success()
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Đã thanh toán, phương thức: Paypal
            return View();
        }

        public IActionResult Fail()
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Chưa thanh toán, phương thức: 
            return View();
        }
    }
}