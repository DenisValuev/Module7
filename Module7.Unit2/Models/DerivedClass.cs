using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class DerivedClass : BaseClass
    {
        private int counter;

        public override int Counter
        {
            get { return counter; }
            set 
            {
                if (value >= 0)
                {
                    counter = value;
                }
                else
                {
                    Console.WriteLine("Значение числа должно быть не меньше нуля");
                }
            }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}
