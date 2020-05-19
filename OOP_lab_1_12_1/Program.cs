using System;

namespace OOP_lab_1_12_1
{
    public class Program
    {
        public static double function(int x)
        {
            return x * x * x - 4 * x * x - 5 * x + 9 + Math.Cos(x);
        }

        static void Main(string[] args)
        {
            Console.Write("x = ");
            Console.WriteLine("y = {0}", function(int.Parse(Console.ReadLine())));
        }
    }
}
