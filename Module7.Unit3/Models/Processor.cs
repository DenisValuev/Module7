using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit3.Models
{
    internal class Processor : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Processor is work!");
        }
    }
}
