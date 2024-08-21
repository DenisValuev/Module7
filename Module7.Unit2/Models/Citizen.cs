using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class Citizen
    {
        public virtual double Age { get; set; }
        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }
}
