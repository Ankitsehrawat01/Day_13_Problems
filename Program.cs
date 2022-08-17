using Day_13_Practice_Problem;
namespace Day_13_Practice_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            FindMax obj1 = new FindMax();
            while (check)
            {
                Console.Write("Select Option:\n" +
                    "1)Find Integer Maximum Number\n" + "2)Find float Maximum Number\n" + "3)Find Maximum String\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int result = obj1.FindMx<int>(4, 3, 2);
                        Console.WriteLine(result);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 2:
                        float result2 = obj1.FindMx<float>(4.3f, 3.5f, 2.5f);
                        Console.WriteLine(result2);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum float is:" + result2);// To display Maximum float
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 3:
                        string result3 = obj1.FindMx<string>("A", "B", "C");
                        Console.WriteLine(result3);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum string is:" + result3);// To display Maximum string
                        Console.WriteLine("-----------------------------------");
                        break;

                    default:
                        check = !check;
                        break;
                }
            
            }
        }
    }
}
