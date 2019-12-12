using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class HangHoa
    {
        public HangHoa()
        {
            BinhLuanSp = new HashSet<BinhLuanSp>();
            ChiTietHd = new HashSet<ChiTietHd>();
            ChiTietPhieuNhap = new HashSet<ChiTietPhieuNhap>();
            YeuThich = new HashSet<YeuThich>();
        }

        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string MaLoai { get; set; }
        public string Hinh { get; set; }
        public double DonGia { get; set; }
        public double GiamGia { get; set; }
        public string MoTa { get; set; }
        public string MaNcc { get; set; }
        public int? SoLuong { get; set; }
        public string SanPhamMoi { get; set; }
        public string TenHhSeoUrl => TenHh.ToUrlFriendly();
        public string MoTaChung { get; set; }

        public Loai MaLoaiNavigation { get; set; }
        public NhaCungCap MaNccNavigation { get; set; }
        public ICollection<BinhLuanSp> BinhLuanSp { get; set; }
        public ICollection<ChiTietHd> ChiTietHd { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
        public ICollection<YeuThich> YeuThich { get; set; }
    }
}
