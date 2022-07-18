using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Quotient_Reminder
    {
        public static void show_remainder()
        {
            Console.WriteLine("Enter the 1st Number = ");
            int devident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number = ");
            int divisor=Convert.ToInt32(Console.ReadLine());
            int q = devident / divisor;
            int r= devident % divisor;
            Console.WriteLine("Quotient =" + q);
            Console.WriteLine("Reminder = "+r);
        }
    }
}
