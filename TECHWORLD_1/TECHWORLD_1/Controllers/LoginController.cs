using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class LoginController : Controller
    {
        private readonly TechWorld_2Context db;
        public LoginController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(Login lg)
        {
            KhachHang kh = db.KhachHang.SingleOrDefault(p => p.TaiKhoan == lg.TenDangNhap && p.MatKhau == Encryptor.MD5Hash(lg.MatKhau));
            if (kh != null)
            {
                HttpContext.Session.Set("Username", kh);
                return RedirectToAction("Index", "Home"); 
            }
            else
            {
                ViewBag.NotExit = false;
                return View("Index");
            }
            
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");           
            return RedirectToAction("Index", "Login");
        }
    }
}