using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit5.Models
{
    static class StringExtensions
    {
        public static char GetLastChar(this string source) => source[source.Length - 1];
    }
}
