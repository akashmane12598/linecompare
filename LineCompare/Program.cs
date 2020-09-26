using System;

namespace LineCompare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
            Console.WriteLine("Enter the values of x1 and y1");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1=  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x2 and y2");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double var = Math.Pow((x2 - x1), 2)+Math.Pow((y2-y1),2);
            double length = Math.Sqrt(var);
            Console.WriteLine("Length of a line is: "+Math.Round(length,2));
        }
    }
}
