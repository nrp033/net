using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC1_cartasian
    {
        public static void show_cartesian()
        {
            Console.Write("Enter the value of x1 ="); int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(  "Enter the value of x2 ="); int x2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y1 ="); int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y2 ="); int y2 = Convert.ToInt32(Console.ReadLine());
            
            double line = Math.Sqrt((x2 - x1)^2 + (y2 - y1)^2);
            Console.WriteLine("Line 1 =" +line);

            }

        }

    }
