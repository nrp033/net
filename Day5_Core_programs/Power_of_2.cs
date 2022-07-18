using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Power_of_2
    {
        public static void power_show()
        {
            Console.WriteLine("Enter the value = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result=0;
            for(int i=1;i<=n;i++)
            {
                result += n;
                Console.WriteLine(result);
            }
            
        }
    }
}
