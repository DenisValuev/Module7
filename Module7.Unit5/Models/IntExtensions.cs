using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit5.Models
{
    static class IntExtensions
    {
        public static int GetNegative(this int source)
        {
            if (source > 0) 
                return source * -1;
            else
                return source;
        }
        public static int GetPositive(this int source)
        {
            if (source < 0)
                return source * -1;
            else 
                return source;
        }
    }
}
