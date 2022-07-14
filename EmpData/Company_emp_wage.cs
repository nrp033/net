using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    internal class Company_emp_wage
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        
        public static int company_wise_wage(string company, int EmpRatePerHr, int numOfWorkingDays, int maxHrPerMonth)
        {
            int emphr = 0;
            int totalemphr = 0;
            int totalWorkingdays = 0;
            while(totalemphr<=maxHrPerMonth && totalWorkingdays<numOfWorkingDays)
            {
                totalWorkingdays++;
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
                totalemphr += emphr;
                Console.WriteLine("Day #:"+ totalWorkingdays +"  "+"Employee working Hours =   " + totalemphr);

            }
            int monthwage = totalemphr * EmpRatePerHr;
            Console.WriteLine("Total Employee Wage for Company =" +company+"  is   "+  monthwage);
            return monthwage;
        }
    }
}
