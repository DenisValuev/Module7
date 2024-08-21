using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit3.Models
{
    internal class Cat : FourLeggedAnimal
    {
        public override string Name { get; set; }
        public override void Describe()
        {
            Console.WriteLine("Это животное - кошка");
        }
    }
}
