using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Leap_or_Not
    {
        public static void leap_show()
        { 

            Console.WriteLine("Enter the Year = ");
            int year = Convert.ToInt32(Console.ReadLine());
            if(((year % 4 ==0) && (year % 100 !=0)) ||(year % 400 == 0))
            {
                Console.WriteLine("Year\t" + year + "\tis Leap Year !");
            }
            else
            {
                Console.WriteLine(year+"\t is not Leap year !");
            }
        }
    }
}
