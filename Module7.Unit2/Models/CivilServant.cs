using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class CivilServant : Citizen
    {
		private double age;
        public override double Age 
        { 
            get => age;
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим, гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }


    }
}
