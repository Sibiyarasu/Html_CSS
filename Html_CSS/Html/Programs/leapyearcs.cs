using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    partial class oddeven

    {
        int year = 2024;

        public void m1()
        {
            if(2024 % 4 == 0)
            {

                Console.WriteLine("THIS IS LEAP YEAR");
            }
            else
            { 
                Console.WriteLine("this is not a leap year");
            }

        }
    }
}
