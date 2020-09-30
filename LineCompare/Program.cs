using System;

namespace LineCompare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
            Program pg = new Program();
            pg.linecompare();
        }
        public void linecompare()
        {
            Console.WriteLine("Enter the values of x1 and y1");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x2 and y2");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());
            double var = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            string length = Math.Round(Math.Sqrt(var),2).ToString();
            Console.WriteLine("Length of a line1 : " + length);
            Console.WriteLine("Enter the values of x3 and y3");
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());
            double var1 = Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2);
            string length2 = Math.Round(Math.Sqrt(var1),2).ToString();
            Console.WriteLine("Length of a line2 : " + length2);
            if (length.CompareTo(length2)==0)
            {
                Console.WriteLine("Two lines are equal");
            }
            else if (length.CompareTo(length2) == 1)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("Line1 is smaller than Line2");
            }
        }
    }
}
