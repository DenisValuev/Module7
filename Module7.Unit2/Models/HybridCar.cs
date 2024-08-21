using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class HybridCar : Car
    {
        public FuelType FuelType;
        public double Gas;
        public double Electricity;
        public HybridCar()
        {
            Electricity = 50;
            Gas = 50;
        }
        public override void Move()
        {
            Console.WriteLine("Вызван метод Move класса HybridCar");
            Mileage++;
            switch (FuelType)
            {
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }
        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }
}
