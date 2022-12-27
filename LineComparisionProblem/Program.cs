using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problems");
            Console.WriteLine("Enter the Co-Ordinates of line1");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            double length1 = Math.Pow(x2 - x1, 2);
            double length2 = Math.Pow(y2 - y1, 2);
            double sumOfLine1 = length1 + length2;

            double totalLength1 = Math.Sqrt(sumOfLine1);
            Console.WriteLine(" Total Length of Line " + totalLength1);

            Console.WriteLine("Enter the Co-Ordinates of line2");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());

            double length3 = Math.Pow(a2 - 1, 2);
            double length4 = Math.Pow(y2 - y1, 2);
            double sumOfLine2 = length3 + length4;

            double totalLength2 = Math.Sqrt(sumOfLine2);
            Console.WriteLine(" Total Length of Line " + totalLength2);
            if (totalLength1.CompareTo(totalLength2) > 0)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (totalLength1.CompareTo(totalLength2) < 0)
            {
                Console.WriteLine("Line2 is greater than line1");
            }
            else
            {
                Console.WriteLine("Line1 is equal to Line2");
            }
        }

    }
}