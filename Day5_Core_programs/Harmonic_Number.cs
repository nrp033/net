using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Harmonic_Number
    {
        public static void show_harmonic()
        {
            double sum = 0;
            Console.WriteLine("Enter the Number of Terms to Add =");
            double Number = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=Number;i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine("Sum of Harmonic series of " + Number+ " is =" + sum);
        }
    }
}
