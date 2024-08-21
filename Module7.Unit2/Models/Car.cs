using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class Car
    {
        public int Mileage;
        public Car()
        {
            Mileage = 0;
        }
        public virtual void Move()
        {
            Console.WriteLine("Вызван метод Move класса Car");
            Mileage++;
        }
    }
}
