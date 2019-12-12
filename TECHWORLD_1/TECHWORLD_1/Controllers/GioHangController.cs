using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class GioHangController : Controller
    {
        private readonly TechWorld_2Context db;
        public GioHangController(TechWorld_2Context ctx)
        {
            db = ctx;
        }

        public List<CartItem> Cart
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

       
        public IActionResult Index()
        {
            return View(Cart);
        }

        [HttpPost]        
        public IActionResult AddToCart(int mahh, int soluongsp)
        {
           
            List<CartItem> giohang = Cart;
            //tim xem co chua
            CartItem item = giohang.SingleOrDefault(p => p.MaHh == mahh);
            if (item != null) //co roi
            {
                item.SoLuong++;
            }
            else
            {
                HangHoa hanghoa = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh);
                item = new CartItem
                {
                    MaHh = hanghoa.MaHh,
                    TenHh = hanghoa.TenHh,
                    Hinh = hanghoa.Hinh,
                    SoLuong = soluongsp,
                    GiaBan = hanghoa.DonGia * (1 - hanghoa.GiamGia)

                };
                giohang.Add(item);
            }
            //luu vao session
            HttpContext.Session.Set("GioHang", giohang);
            return RedirectToAction("Index");
        }
       
        public IActionResult ClearCart(int mahh_clr)
        {
            List<CartItem> giohang = Cart;
            CartItem hanghoa = giohang.SingleOrDefault(p => p.MaHh == mahh_clr);
            giohang.Remove(hanghoa);
            HttpContext.Session.Set("GioHang", giohang);
            return RedirectToAction("Index");
        }
        
    }
}



