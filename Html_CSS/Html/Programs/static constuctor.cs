using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class static_constuctor
    {
        public static int a = 5;
        public  static int b = 10;
        //public string i = "sibi";


        public static_constuctor()
        {
            Console.WriteLine($"Default parameter "+ DateTime.UtcNow);

        }

        public static_constuctor( int c)
        {
            Console.WriteLine($"parameter const " + c);

        }

        static static_constuctor()
        {
            Console.WriteLine($" static " + DateTime.UtcNow);

        }
         public static void StaticMethod()
        {
            Console.WriteLine(a);
        }
        public static void NonStaticMethod()
        {
            Console.WriteLine(b);
        }

    }
}
