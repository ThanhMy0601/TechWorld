using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHd = new HashSet<ChiTietHd>();
        }

        public int MaHd { get; set; }
        public int MaKh { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SdtNguoinhan { get; set; }
        public string GhiChu { get; set; }
        public double PhiVanChuyen { get; set; }
        public int MaTrangThai { get; set; }
        public string MaNv { get; set; }
        public double? TongTienHang { get; set; }
        public string MaVoucher { get; set; }
        public double? TongThucThu { get; set; }
        public int? PhuongThucThanhToan { get; set; }
        public int? TinhTrangThanhToan { get; set; }

        public KhachHang MaKhNavigation { get; set; }
        public TrangThai MaTrangThaiNavigation { get; set; }
        public ICollection<ChiTietHd> ChiTietHd { get; set; }
    }
}
