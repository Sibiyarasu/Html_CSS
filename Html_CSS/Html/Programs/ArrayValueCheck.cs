using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class ArrayValueCheck
    {
        int temp = 0;

            int[] num = new int[] { 1, 3, 2, 6 ,5};
            int[] num1 = new int[] { 1, 3, 2,6};
        public void m1()
        {
            if (num.Length == num1.Length)
            {

                for (int i = 0; i < num.Length; i++)
                {

                    if (num[i] == num1[i])


                    {
                        temp++;
                    }

                }
                        if (temp == num.Length)
                        {
                            Console.WriteLine("The same numbers are----" + temp);
                        }
                else 
                {
                    Console.WriteLine("not same"+temp);

                }
             }
            else
            {

                Console.WriteLine("Both the array are not same");

            }

        }
    } }
