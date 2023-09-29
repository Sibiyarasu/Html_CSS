using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class dowhile
    {
        public void MenuDriven()
        {
            int a = 0;

            while (a > 5)
            {
                Console.WriteLine(a);
                a++;
            }

            int b = 0;
            do
            {
                Console.WriteLine(b);

            } while (b > 5);



            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");

                b = Convert.ToInt32(Console.ReadLine());

                
                switch (b)
                {
                    case 1:

                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first + second);
                        break;
                    case 2:

                        int first1 = Convert.ToInt32(Console.ReadLine());
                        
                        int second1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(first1 - second1);
                        break;

                    default:
                        Console.WriteLine("Please give a valid OPtion");
                        break;
                }

            } while (b != 0);


        }



    }
}

    

