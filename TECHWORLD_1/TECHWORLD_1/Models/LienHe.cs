using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class LienHe
    {
        public int MaHd { get; set; }
        public int MaKh { get; set; }
        public int? MaNv { get; set; }
        public string TenKH_Lien_He { get; set; }
        public string EmailKH_Lien_He { get; set; }
        public string SoDienThoaiKH_Lien_He { get; set; }
        public string CauHoi { get; set; }
        public string TraLoi { get; set; }
        public DateTime NgayGui { get; set; }
        public bool TrangThaiTl { get; set; }

        public KhachHang MaKhNavigation { get; set; }
        public NhanVien MaNvNavigation { get; set; }
    }
}
