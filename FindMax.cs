using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Practice_Problem
{
    public class FindMax
    {
        public int FindMxInteger(int First, int Second, int Third)
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0 )
            {
                return First;
            }
            if (Second.CompareTo(Third) > 0 &&  Second.CompareTo(First) > 0 )
            {
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0 )
            {
                return Third;
            }
            return 0;
        }
    }
}
