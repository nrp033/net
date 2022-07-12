using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    internal class Part_time
    {
        //Program to check if Empoyee is Parttime or Full time.


        public static void Parttime()
        {
            int is_part_time = 1;
            int is_full_time = 2;
            int rate_per_hr = 20;
            int emphr = 0;
            int empwage = 0;
            Random rd = new Random();
            int empcheck = rd.Next(0, 3);
            if(empcheck == is_part_time)
            {
                emphr = 4;
            }
            else if(empcheck == is_full_time)
            {
                emphr = 8;

            }
            else
            {
                emphr = 0;
            }

            empwage = emphr * rate_per_hr;
            Console.WriteLine("Total Wages is = " + empwage);
        }
    }
}
