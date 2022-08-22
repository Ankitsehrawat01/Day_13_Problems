using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Practice_Problem
{
    public class Maximum<T>
    {
        public T[] value;
        public Maximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T MaxValues(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValues(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValues(this.value);
            Console.WriteLine("---------");
            Console.WriteLine("Maximum value is " + max);
            Console.WriteLine("---------");
        }
    }
}
