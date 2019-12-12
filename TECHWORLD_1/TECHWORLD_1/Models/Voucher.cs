using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class Voucher
    {
        public string MaVc { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public double? GiamGia { get; set; }
        public long? TongTienDk { get; set; }
        public bool? TrangThai { get; set; }
    }
}
