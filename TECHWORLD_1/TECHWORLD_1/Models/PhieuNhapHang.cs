﻿using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class PhieuNhapHang
    {
        public PhieuNhapHang()
        {
            ChiTietPhieuNhap = new HashSet<ChiTietPhieuNhap>();
        }

        public int MaPn { get; set; }
        public DateTime NgayNhap { get; set; }
        public double? TongTien { get; set; }

        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
    }
}
