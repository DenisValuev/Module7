using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit3.Models
{
    internal class Employee : Person
    {
        public bool IsOnShift;
        public Employee(string name, bool inOnShift) : base(name)
        {
            IsOnShift = inOnShift;
        }
    }
}
