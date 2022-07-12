using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    internal class Emp_wage_Case

    {
        //Program to check if Employee is Present or Absent and Full time or Part time Using Switch case.


        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int rate_per_hour = 20;
        public static void Emp_Case()
        {
            int emphr = 0;
            int empwage = 0;
            Random rd= new Random();
            int empcheck = rd.Next(0, 3);
            switch (empcheck)
            {
                case is_part_time:
                    emphr = 4;
                    break;
               case is_full_time:
                    emphr = 8;
                    break;
                default:
                    emphr = 0;
                    break;
            }
            empwage = emphr * rate_per_hour;
            Console.WriteLine("Total wage is = " + empwage);



        }
    }
}
