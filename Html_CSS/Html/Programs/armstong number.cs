using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class armstrongnum
    { 
            int a;

            public void m1()
            {
                Console.WriteLine("Enter a number");
                a = Convert.ToInt32(Console.ReadLine());

                int b = a;

                int temp = 0;
                while (a != 0)
                {
                    int s = a % 10;
                    temp = s+(b * b * b) ;
                a = a / 10;
                }
                if (a == temp)
                {
                    Console.WriteLine("The given number  is armsrtong number");
                }
                else
                {
                    Console.WriteLine("The given number  is not a armsrtong number");

                }
            }
        }
    }




