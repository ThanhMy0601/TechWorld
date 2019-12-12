using System;
using System.Collections.Generic;

namespace TECHWORLD_1.Models
{
    public partial class Loai
    {
        public Loai()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
