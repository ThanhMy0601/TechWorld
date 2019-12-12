using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class LienHeController : Controller
    {
        private readonly TechWorld_2Context db;
        public LienHeController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index(string phanhoikh, string submit)
        {

            if (HttpContext.Session.Get<KhachHang>("Username") != null)
            {
                LienHe lh = new LienHe
                {
                    MaKh = HttpContext.Session.Get<KhachHang>("Username").MaKh,
                    CauHoi = phanhoikh,
                    NgayGui = DateTime.Now
                                     
                };
                db.LienHe.Add(lh);
                db.SaveChanges();
                ViewBag.Exit = true;
            }
            else
            {
                ViewBag.Exit = false;
            }
           
            return View();
        }
    }
}