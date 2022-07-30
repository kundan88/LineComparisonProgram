using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Program
    {
        public static void LengthOfLine()
        {
            Console.WriteLine("Welcome to Line Comparision Program");
            Console.WriteLine();
            Console.WriteLine("Enter the coordinates: ");

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            double line1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(" length Of Line is: " + Math.Round(line1, 3));

        }
    }
}
