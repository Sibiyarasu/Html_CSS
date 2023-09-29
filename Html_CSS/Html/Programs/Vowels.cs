using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{  
    class Vowels
    {

        public void tocheckvowels()
        {
            Console.WriteLine("Enter a character");
            char name = Convert.ToChar(Console.ReadLine());


            if( name == 'a' || name == 'e' || name == 'i' || name == 'o' || name == 'u' )
            {
                Console.WriteLine("The character is a vowel");
            }
            else
            {
                Console.WriteLine("The character is not a vowel");

            }
        }
    }
}
