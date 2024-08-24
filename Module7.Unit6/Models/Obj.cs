using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit6.Models
{
    internal class Obj
    {
        public void Display<T>(T param)
        {
            Console.WriteLine(param.ToString());
        }
    }
}
