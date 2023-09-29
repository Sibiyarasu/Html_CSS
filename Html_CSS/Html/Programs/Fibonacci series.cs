using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class Fibonacci_series
    {
        int a = 0;
        int b = 1;
        int temp = 0;

        public void fiboseries()
        {
            for( int i=0;i<30;i++)
            {
                temp = a + b;
                a = b;
                b = temp;
                temp++;

                Console.WriteLine("fibonacci series is  "+temp);
            }
        }
    }
}
