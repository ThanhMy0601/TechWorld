using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class BlogController : Controller
    {
        private readonly TechWorld_2Context db;
        public BlogController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails(int matt)
        {
            Blog blog = db.Blog.SingleOrDefault(p => p.MaTt == matt);
            return View(blog);
        }
    }
}