using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class swaping
    {
        int a = 5;
        int b = 6;
        int temp;
            public void swapping()
        {
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }


    class Aa
    {
        int a;
        int b;
        
        
        public void thirdparty()
        {
            Console.WriteLine("Enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine(a);
            Console.WriteLine(b);

        }

}


        

}

