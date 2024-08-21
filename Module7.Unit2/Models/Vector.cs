using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class Vector
    {
        public int X;
        public int Y;
        public Vector Add(Vector second)
        {
            return new Vector
            {
                X = this.X + second.X,
                Y = this.Y + second.Y
            };
        }
        public static Vector operator +(Vector a, Vector b) 
        {
            return new Vector
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }
    }
}
