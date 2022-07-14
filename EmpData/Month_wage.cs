using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    internal class Month_wage
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int rate_per_hr = 20;
        public const int no_of_working_days = 20;
            public static void monthwage()
        {

            int emphr = 0;
            int empwage = 0;
            int totalempwage = 0;
           
            for(int day=0;day<no_of_working_days;day++)
            {
                Random rd = new Random();
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
                        emphr = 0;
                        break;

                }
                empwage = emphr * rate_per_hr;
                totalempwage+=empwage;
                Console.WriteLine("Employee Wages=" + empwage);

            }
            Console.WriteLine("Total Month Employee wage=" +totalempwage);  
        }
    }
}
