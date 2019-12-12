using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class HoaDonsController : Controller
    {
        private readonly TechWorld_2Context _context;

        public HoaDonsController(TechWorld_2Context context)
        {
            _context = context;
        }

        // GET: HoaDons
        public async Task<IActionResult> Index()
        {
            var techWorld_2Context = _context.HoaDon.Include(h => h.MaKhNavigation).Include(h => h.MaTrangThaiNavigation);
            return View(await techWorld_2Context.ToListAsync());
        }

        // GET: HoaDons/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = _context.ChiTietHd.Where(m => m.MaHd == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: HoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon
                .Include(h => h.MaKhNavigation)
                .Include(h => h.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(m => m.MaHd == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // POST: HoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDon = await _context.HoaDon.FindAsync(id);
            _context.HoaDon.Remove(hoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ChangeStatus(int id)
        {
            var hd = _context.HoaDon.Find(id);
            if (hd != null)
            {
                if (hd.MaTrangThai == 0)
                {
                    hd.MaTrangThai = 1;
                    _context.SaveChanges();
                }
                else if (hd.MaTrangThai == 1)
                {
                    hd.MaTrangThai = 0;
                    _context.SaveChanges();
                }

            }
            return RedirectToAction("Index");
        }
        public IActionResult ChangeTinhTrangTT(int id)
        {
            var hd = _context.HoaDon.Find(id);
            if (hd != null)
            {
                if (hd.TinhTrangThanhToan == 0)
                {
                    hd.TinhTrangThanhToan = 1;
                    _context.SaveChanges();
                }
                else if (hd.TinhTrangThanhToan == 1)
                {
                    hd.TinhTrangThanhToan = 0;
                    _context.SaveChanges();
                }

            }
            return RedirectToAction("Index");
        }
        private bool HoaDonExists(int id)
        {
            return _context.HoaDon.Any(e => e.MaHd == id);
        }
    }
}
