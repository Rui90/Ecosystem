using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecosystem.Core.Base.Extensions
{
    public static class StringExtension
    {

        public static bool CustomContains(this string s, string contains)
        {
            if (!string.IsNullOrWhiteSpace(s) && !string.IsNullOrWhiteSpace(contains))
            {
                return s.ToLowerInvariant().Contains(contains.ToLowerInvariant());
            }
            return string.IsNullOrWhiteSpace(s) && string.IsNullOrWhiteSpace(contains);
        }
    }
}
