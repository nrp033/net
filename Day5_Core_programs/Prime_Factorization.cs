using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Prime_Factorization
    {
        public static void show_factorization()
        {
            Console.WriteLine("Enter the Number = ");
            int num= Convert.ToInt32(Console.ReadLine());
            while (num != 1)
            {

                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.Write("  " + i);
                        num /= i;

                    }
                }
       
            }
            Console.ReadKey();
        }
    }
}
