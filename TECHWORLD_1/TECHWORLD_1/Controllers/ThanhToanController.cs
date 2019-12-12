using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class ThanhToanController : Controller
    {
        public readonly TechWorld_2Context db;
        public ThanhToanController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<CartItem> Carts
        {
            get
            {
                List<CartItem> myCart = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (myCart == default(List<CartItem>))
                {
                    myCart = new List<CartItem>();
                }

                return myCart;
            }
        }
        [HttpPost]
        public IActionResult HoaDonTV(string ghichu)
        {
            KhachHang kh = HttpContext.Session.Get<KhachHang>("Username");
            HoaDon hd = new HoaDon
            {
                MaKh = kh.MaKh,
                HoTen = kh.HoTen,
                DiaChi = kh.DiaChi,
                GhiChu = ghichu,
                NgayDat = DateTime.Now,
                MaTrangThai = 0,
                PhuongThucThanhToan = 0,
                TinhTrangThanhToan = 0,
                PhiVanChuyen = 0

            };
            db.HoaDon.Add(hd);
            double tongtien = 0;
            double tonghoadon = 0;

            foreach (var i in Carts)
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


                if (hh.SoLuong >= cthd.SoLuong)
                {
                    hh.SoLuong = hh.SoLuong - cthd.SoLuong;
                }
                else
                {
                    HangHoa hanghoa = db.HangHoa.SingleOrDefault(p => p.MaHh == cthd.MaHh);
                    string hethang = "Mặt hàng " + hanghoa.TenHh + " Chỉ còn : " + hh.SoLuong + " sản phẩm";
                    HttpContext.Session.Set("HetHang", hethang);
                    db.ChiTietHd.Remove(cthd);
                    db.HoaDon.Remove(hd);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            tonghoadon = tongtien + 0;
            hd.TongTienHang = tongtien;
            hd.TongThucThu = tonghoadon;
            db.SaveChanges();
            HttpContext.Session.Set<string>("OrderSuccess", "Đơn hàng của bạn đã được đặt thành công.");
            //ViewBag.OrderSuccess = true;
            HttpContext.Session.Remove("GioHang");


            return RedirectToAction("Index");
        }
    }
}