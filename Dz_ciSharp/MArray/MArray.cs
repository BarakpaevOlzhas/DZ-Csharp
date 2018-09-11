using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMArray
{
    public class MArray
    {
        public int[] Array { get; set; }
        
        public int this[int index]
        {
            get
            {
                return Array[index];
            }
            set
            {
                Array[index] = value * value;
            }
        }

        public int ReturnToIndex(int index)
        {
            return Array[index];
        }

    }
}
