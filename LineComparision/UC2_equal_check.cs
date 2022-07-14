using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC2_equal_check
    {
        public static void show_equal()
        {
            Console.Write("Enter the value of x1 ="); int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of x2 ="); int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y1 ="); int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y2 ="); int y2 = Convert.ToInt32(Console.ReadLine());

            double line = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Line 1 =" + line);

            Console.Write("Enter the value of x3 ="); int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of x4 ="); int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y3 ="); int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y4 ="); int y4 = Convert.ToInt32(Console.ReadLine());

            double line2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("line 2 =" + line2);
            if (line == line2)
            {
                Console.WriteLine("Lines are equal!");

            }
            else
            {
                Console.WriteLine("Lines are Not Equal");

            }
        }
    }
}