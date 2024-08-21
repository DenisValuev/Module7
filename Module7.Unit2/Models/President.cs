using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class President : CivilServant
    {
		private double age;

		public override double Age
		{
			get { return age; }
			set 
			{

                if (value < 35)
                {
                    Console.WriteLine("Для работы госслужащим, гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
		}

	}
}
