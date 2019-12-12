using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class Blog
    {
        public int MaTt { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung1 { get; set; }
        public string NoiDung2 { get; set; }
        public string NoiDung3 { get; set; }
        public string Hinh { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? TrangThai { get; set; }

    }
}
