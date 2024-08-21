using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit2.Models
{
    internal class IndexingClass
    {
        private int[] array;
        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        { 
            get 
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else 
                {
                    return 0;
                }
            } 
            set 
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }
    }
}
