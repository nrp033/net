using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_basic_core_programs
{
    internal class Alphabet_vowel_Consonant
    {
        public static void  show_vowelconsonant()
        { 
            Console.Write("Enter the Alphabet =  ");
            char c =Convert.ToChar( Console.ReadLine());
            if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'|| c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            { 
                Console.WriteLine("Entered Alphabet is Vowel !");
            }
            else
            {
               Console.WriteLine(   "Enterde Alphabet is Consonant !"); 
            }
            Console.ReadKey();



        }
    }
}
