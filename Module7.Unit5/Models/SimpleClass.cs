using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit5.Models
{
    internal class SimpleClass
    {
        public static int MinValue = 100;
        public int Value;
        public SimpleClass(int value)
        {
            if (value < MinValue)
            {
                Value = MinValue;
            }
            else
            {
                Value = value;
            }
        }
    }
}
