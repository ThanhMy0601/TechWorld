using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TECHWORLD_1.Models;
using Quartz;
using Microsoft.EntityFrameworkCore;

namespace TECHWORLD_1.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly TechWorld_2Context db;
        public HangHoaController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index(string loai="")
        {         
            /*List<HangHoa> hanghoa = db.HangHoa.ToList();
            if (loai != null && loai != "")
            {
                hanghoa = db.HangHoa.Where(p => p.MaLoai == loai).ToList();
            }           
            List<HangHoa> res = hanghoa.ToList();
            
            return View("Index",res);*/

            var dsHangHoa = db.HangHoa.AsQueryable();
            if (loai!=null&&loai!="")
            {
                dsHangHoa = dsHangHoa.Where(p => p.MaLoai == loai);
            }
            Random rd_hhs = new Random();
            var hangHoas = dsHangHoa.OrderBy(x => rd_hhs.Next()).ToList();
           
            /*if (loai != null && loai != "")
            {
                Loai loaihh = db.Loai.SingleOrDefault(p => p.MaLoai == loai);
                ViewBag.Loai = loai;

            List<HangHoa> hh = db.HangHoa.ToList();
                            Random rd = new Random();
                            List<HangHoa> hh_rd = hh.OrderBy(x => rd.Next()).ToList();// lưu trữ một danh sách hàng hóa đã được random
            }*/

            return View(hangHoas);

        }
       /* [Route("{url}")]
        public IActionResult IndexHh(string url)
        {
          
            var dsHangHoa = db.HangHoa.AsQueryable();
            dsHangHoa = dsHangHoa.Where(p => p.MaLoaiNavigation.TenLoai.ToUrlFriendly() == url);

            var hangHoas = dsHangHoa.ToList();
           

            return View("Index",hangHoas);

        }*/
        public IActionResult ChiTiet(int mahh)
        {
            HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh); //tạo một oject HangHoa là hh để lưu trữ một hàng hóa 
            if (hh != null)
            {
                return View(hh); //SingleOrDefault trả về một đối tượng được tìm thấy nếu trùng khớp nếu ko có đối tượng nào để trả về danh sách nó sẽ trả về một đối tượng mặc định
            }
            return RedirectToAction(controllerName: "Home", actionName: "Error");
        }

        //[Route("[controller]/{url}")]
        [Route("san-pham/{mahh}/{url}")]
        public IActionResult ChiTietHh(int mahh, string url)
        {
            HangHoa hh = db.HangHoa.SingleOrDefault(p => p.TenHhSeoUrl == url);
            if (hh != null)
            {
                return View("ChiTiet", hh);
            }
            return RedirectToAction(controllerName: "Home", actionName: "Error");
        }

        
        public async Task<IActionResult> Search(string searchstring)
        {
            var searchs = from m in db.HangHoa select m;
            if (!String.IsNullOrEmpty(searchstring))
            {
                searchs = searchs.Where(s => s.TenHh.Contains(searchstring));// trả về hàng tên hàng hóa có chứa searchstring
            }
            return View("Index",await searchs.ToListAsync());
        } 
        
        public IActionResult BinhLuan(string binhluan, int mahh)
        {
            if (HttpContext.Session.Get<KhachHang>("Username") != null)
            {
                BinhLuanSp binhluanSP = new BinhLuanSp
                {
                    NoiDung=binhluan,
                    MaKh= HttpContext.Session.Get<KhachHang>("Username").MaKh,
                    MaHh=mahh,
                    NgayBl=DateTime.Now
                };
                HangHoa hanghoa = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh);

                db.BinhLuanSp.Add(binhluanSP);
                db.SaveChanges();

                return View("ChiTiet", hanghoa);
            }
            else
            {
                ViewBag.UserExit = false;
                HangHoa hanghoa = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh);
                return View("ChiTiet",hanghoa);
            }
            
        }
    }
}