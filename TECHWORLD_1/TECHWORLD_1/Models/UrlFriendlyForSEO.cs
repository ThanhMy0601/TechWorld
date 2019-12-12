using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TECHWORLD_1.Models
{
    public static class UrlFriendlyForSEO
    {
        public static string ToUrlFriendly(this string tieuDe)
        {
            string str = tieuDe.ToLower().Trim();
            // thay the tieng viet
            str = Regex.Replace(str, @"[áàạãảăắằặẵẳâấầậẫẩ]", "a");
            str = Regex.Replace(str, @"[úùụũủứừựữửư]", "u");
            str = Regex.Replace(str, @"[éèẹẽẻếềệễểê]", "e");
            str = Regex.Replace(str, @"[óòọõỏốồộỗổôớờợỡởơ]", "o");
            str = Regex.Replace(str, @"[íìịĩỉ]", "i");
            str = Regex.Replace(str, @"[đ]", "d");
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            str = Regex.Replace(str, @"\s+", "-").Trim();
            str = Regex.Replace(str, @"\s", "-");
            return str;
        }
    }
}
