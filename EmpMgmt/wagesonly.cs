using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    internal class wagesonly
    {
        //Program to check wage of Employee.


        public static void wagecal()
        {
            int is_full_time = 1;
            int rate_per_hr = 20;
            int emphr = 0;
            int empwage = 0;
            Random rd= new Random();
            int empcheck = rd.Next(0,2);
            if(empcheck == is_full_time)
            {
                emphr = 8;
            }
            else
            {
                emphr=0;
            }
            empwage = emphr * rate_per_hr;
            Console.WriteLine("Employee Wage = " +empwage);
        }
    }
}
