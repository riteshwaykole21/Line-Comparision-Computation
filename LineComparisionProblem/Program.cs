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
            Console.WriteLine("Enter the Co-Ordinates of line");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            double length1 = Math.Pow(x2 - x1, 2);
            double length2 = Math.Pow(y2 - y1, 2);
            double sumOfLine = length1 + length2;

            double totalLength = Math.Sqrt(sumOfLine);
            Console.WriteLine(" Total Length of Line " + totalLength);
            Console.ReadLine(); 
        }
       
    }
}