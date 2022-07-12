using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    public class presentee
    {
        //Program to check if Employee is Present or Absent.

       public static void emp_presentee()
        {
            int is_present = 1;
            Random rd = new Random();
            int echeck = rd.Next(0,2);
            if (echeck == is_present)
            {
                Console.WriteLine("Employee is Present.") ;

            }
            else
            {
                Console.WriteLine("Employee is Absent.");

            }
        }
    }
}
