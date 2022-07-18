using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Swap_Numbers
    {
        public static void show_swap()

        {
            int c;

            Console.WriteLine("Enter the Value of A = ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the value of B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine(" Values After Swap---");
            Console.WriteLine("Value of A after Swap =" + a);
            Console.WriteLine("Value of B after Swap =" + b);
            Console.ReadKey();
        }

    }
}
