using Day_13_Practice_Problem;
namespace Day_13_Practice_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.Write("Select Option:\n" +
                    "1) Find Integer Maximum Number\n" + 
                    "2) Find float Maximum Number\n" + 
                    "3) Find Maximum String\n" + 
                    "4) Find Maximum integer using sort Method\n" +
                    "5) Find Maximum float using sort Method\n" +
                    "6) Find Maximum string using sort Method\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FindMax<int> obj1 = new FindMax<int>(4, 3, 2);
                        int result = obj1.FindMx();
                        Console.WriteLine(result);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 2:
                        FindMax<float> obj2 = new FindMax<float>(4.3f, 3.5f, 2.5f);
                        float result2 = obj2.FindMx();
                        Console.WriteLine(result2);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum float is:" + result2);// To display Maximum float
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 3:
                        FindMax<string> obj3 = new FindMax<string>("A", "B", "C");
                        string result3 = obj3.FindMx();
                        Console.WriteLine(result3);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum string is:" + result3);// To display Maximum string
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 4:
                        //for integer
                        int[] intArray = { 12, 15, 17, 13, 14, 19, 222 };
                        Maximum<int> obj = new Maximum<int>(intArray);
                        obj.PrintMaxValue();
                        break;
                    case 5:
                        //for float
                        float[] floatArray = { 12.2f, 15.4f, 17.1f, 13.9f };
                        Maximum<float> obj4 = new Maximum<float>(floatArray);
                        obj4.PrintMaxValue();
                        break;
                    case 6:
                        //for string
                        string[] stringArray = { "a", "b", "c", "d", "e" };
                        Maximum<string> obj5 = new Maximum<string>(stringArray);
                        obj5.PrintMaxValue();
                        break;
                }
            }
        }
    }
}
