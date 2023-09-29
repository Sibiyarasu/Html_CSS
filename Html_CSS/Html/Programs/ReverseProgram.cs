using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class ReverseProgram
    { int num;
        public void ReverseInt()
        {
            Console.WriteLine("Enter a number to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
                int  rev = 0;
            while(num>0)
            {
                rev = (rev * 10) + num % 10;
                num = num / 10;
            }

            Console.WriteLine("Reverse number is ");
            Console.WriteLine(rev);
        }
    }
}

