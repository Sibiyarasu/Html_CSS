using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class Switch
    {

        int beauty ;

        public void M1()
        {
            Console.WriteLine("Enter the number");
            beauty = Convert.ToInt32(Console.ReadLine());
            switch (beauty)
            {

            case 3:

                Console.WriteLine(":)");
                break;

            case 4:
                    Console.WriteLine("(*:*)");
                    break;
                default:
                    Console.WriteLine("<:>");
                    break;




            }
        }
    } }
