using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            LienHe = new HashSet<LienHe>();
        }

        public int MaNv { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public int MaPq { get; set; }
        public bool? TrangThaiHd { get; set; }

        public PhanQuyen MaPqNavigation { get; set; }
        public ICollection<LienHe> LienHe { get; set; }
    }
}
