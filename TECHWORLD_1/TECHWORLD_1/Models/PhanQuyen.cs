using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        public int MaPq { get; set; }
        public bool Them { get; set; }
        public bool Sua { get; set; }
        public bool Xoa { get; set; }
        public bool Xem { get; set; }

        public ICollection<NhanVien> NhanVien { get; set; }
    }
}
