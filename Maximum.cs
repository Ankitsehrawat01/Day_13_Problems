using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Practice_Problem
{
    public class Maximum
    {
        //for integer
        public int[] value;
        public Maximum(int[] value)
        {
            this.value = value;
        }
        public int[] Sort(int[] value)
        {
            Array.Sort(value);
            return value;
        }
        public int MaxValues(params int[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public int MaxMethod()
        {
            var max = MaxValues(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValues(this.value);
            Console.WriteLine("Maximum integer value is " + max);
        }
        //for float
        public float[] value1;
        public Maximum(float[] value1)
        {
            this.value1 = value1;
        }
        public float[] Sort(float[] value1)
        {
            Array.Sort(value1);
            return value1;
        }
        public float MaxValues(params float[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public float MaxMethod1()
        {
            var max1 = MaxValues(this.value1);
            return max1;
        }
        public void PrintMaxValue1()
        {
            var max1 = MaxValues(this.value1);
            Console.WriteLine("Maximum float value is " + max1);
        }
        //for string
        public string[] value2;
        public Maximum(string[] value2)
        {
            this.value2 = value2;
        }
        public string[] Sort(string[] value2)
        {
            Array.Sort(value2);
            return value2;
        }
        public string MaxValues(params string[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public string MaxMethod2()
        {
            var max2 = MaxValues(this.value2);
            return max2;
        }
        public void PrintMaxValue2()
        {
            var max2 = MaxValues(this.value2);
            Console.WriteLine("Maximum string value is " + max2);
        }
    }
}
