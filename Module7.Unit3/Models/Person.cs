using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit3.Models
{
    abstract internal class Person
    {
        public string Name;
        protected Person(string name)
        {
            Name = name;
        }
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
}
