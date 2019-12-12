using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TECHWORLD_1.Models
{
    public class CartItem
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string Hinh { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien => GiaBan * SoLuong;
    }
}
