using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    internal class While_Emp_Wages
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int rate_per_hr = 20;
        public const int no_of_working_days = 20;
        public const int max_hr_in_month = 100;

        public static void limit_wages()
        {
            int emphr = 0;
            int totalEmphr = 0;
            int total_working_days = 0;
           
            while(totalEmphr <= max_hr_in_month && total_working_days < no_of_working_days)
            {
                total_working_days++;
                Random rd=new Random();
                int empcheck = rd.Next(0, 3);
                switch(empcheck)
                {
                    case is_part_time:
                        emphr = 4;
                        break;

                    case is_full_time:
                        emphr = 8;
                        break;
                    default:
                        emphr=0;
                        break;


                }
                totalEmphr += emphr;
                Console.WriteLine("Day#:"+total_working_days+"     "+"Employee Hours="+ emphr);
            }
            int totalWage = totalEmphr * rate_per_hr;
            Console.WriteLine("Total Month Employee Wage ="+ totalWage);
        }
    }
}
