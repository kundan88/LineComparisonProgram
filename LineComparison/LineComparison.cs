using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Program
    {
        public static void LineIsGreaterOrEqual()
		{

			int X, Y;
			Console.Write("Compare Line\n");
			Console.Write("-----------------------");
			Console.Write("\n\n");

			Console.Write("Enter the value for X coordinate :");
			X = Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter the value for Y coordinate :");
			Y = Convert.ToInt16(Console.ReadLine());

			//Compare Method
			int compare_val = X.CompareTo(Y);
			Console.WriteLine(compare_val);

			if (compare_val == 0)
			{
				Console.WriteLine("Both Lines are equal");
			}
			else if (compare_val < 0)
			{
				Console.WriteLine("X is less than Y");
			}
			else if (compare_val > 0)
			{
				Console.WriteLine("X is Greater than Y");
			}
		}
	}
}

