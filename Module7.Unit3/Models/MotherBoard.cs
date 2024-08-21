using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit3.Models
{
    internal class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Mother board is work!");
        }
    }
}
