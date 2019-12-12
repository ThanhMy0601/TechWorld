using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class RegisterController : Controller
    {
        public readonly TechWorld_2Context db;
        public RegisterController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string tendangnhap, string matkhau, string hoten, string gioitinh, string diachi, string dienthoai, string email)
        {
            KhachHang username_kh = db.KhachHang.SingleOrDefault(p => p.TaiKhoan == tendangnhap);
            KhachHang email_kh = db.KhachHang.SingleOrDefault(p => p.Email == email);
            if (username_kh != null)
            {
                ViewBag.AccExit = false;
                if (email_kh != null)
                {
                    ViewBag.EmailExit = false;
                }
                return View("Index");
            }
            else if (email_kh != null)
            {
                ViewBag.EmailExit = false;
                return View("Index");
            }
            else
            {
                KhachHang new_khach_hang = new KhachHang
                {
                    TaiKhoan = tendangnhap,
                    MatKhau = Encryptor.MD5Hash(matkhau),
                    HoTen = hoten,
                    GioiTinh = gioitinh,
                    DiaChi = diachi,
                    DienThoai = dienthoai,
                    Email = email
                };
                db.KhachHang.Add(new_khach_hang);
                db.SaveChanges();

                //ViewBag.RegisterSuccess = true;
                return RedirectToAction("Index", "Login");
            }
        }

    }
}