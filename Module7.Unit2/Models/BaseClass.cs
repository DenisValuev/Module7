using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class BaseClass
    {
        public virtual int Counter { get; set; }
        public virtual void Display()
        {
            Console.WriteLine("Метод класса Base");
        }
    }
}
