using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
   partial  class oddeven
    {
        int s = 10;
        
        public void evennumber()
        {
            if(s%10==0)

            {
                Console.WriteLine("The given number is even number");
            }

            else
            {
                Console.WriteLine(" The given number is odd number");
            }
        }
    }
}
