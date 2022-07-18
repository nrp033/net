using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Head_tails_percentage
    {

        public static void flip_percentage()
        {
            Console.WriteLine("Enter Number to Flip Conin = ");
            int No_of_Flips = Convert.ToInt32(Console.ReadLine());
            double head_percentage=0;
            double tails_percentage=0;
            int head = 0;
            int tails = 0;
            Console.WriteLine("You Have Entered =  " + No_of_Flips);
            for(int i=0;i<No_of_Flips;i++)
            {
                Random rd = new Random();
                int flip = rd.Next(0, 2);
                if (flip == 1)
                {
                    head += 1;
                }
                else
                {
                    tails += 1;
                }
                
            }
            head_percentage = (No_of_Flips*head) /  100f;
            tails_percentage = (No_of_Flips*tails) / 100f;

            Console.WriteLine("Heads Percentage = "+head_percentage);
            Console.WriteLine("Tails Percentage = "+tails_percentage);
        }
    }
}

