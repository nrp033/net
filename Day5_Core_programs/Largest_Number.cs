using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Largest_Number
    {
        public static void show_Largest()
        {
            Console.WriteLine("Enter the 1st Value = ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Value = ");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd Value = ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num2>num3)
            {
                Console.WriteLine(num1 + "  is Greatest !");
            }
            else if(num2>num3)
            {
                Console.WriteLine(num2+"  is Greatest !");
            }
            else
            {
                Console.WriteLine(num3 + "  is Greatest !");
            }
        }
    }
}
