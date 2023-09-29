using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class usermenu
    {

        public void CURD()
        {
            int a;

            do {

                Console.WriteLine("Choose a option");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.List");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Update");
a = Convert.ToInt32(Console.ReadLine());


                switch (a)
                {
                    case 1:


                        studentInfoRepository obj = new studentInfoRepository();
                         var SIBI = obj.modelInfo();
                         obj.Insert(SIBI);
                        break;
                    case 2:
                        studentInfoRepository obj1 = new studentInfoRepository();

                        obj1.Select();

                        break;

                    case 3:
                        studentInfoRepository obj2 = new studentInfoRepository();
                        obj2.Delete();
                        break;

                    case 4:

                        studentInfoRepository obj3 = new studentInfoRepository();
                        var update = obj3.modelInfo();
                        obj3.Update(update);
                        
                        break;

                    default:

                        Console.WriteLine("You are choosing a wrong option for CRUD Operation please select the option any one option from 1 to 4");
                        break;
                }

            } while (a != 0);








        }

    } }

