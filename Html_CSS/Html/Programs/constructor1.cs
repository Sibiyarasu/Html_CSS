using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class constructor1

    {
        public int eng;
        public int tam;
        public int maths;
        public int science;
        public int social;
    }

     class mark
        {
        public void m1(constructor1 m)
        {

            Console.WriteLine($"first name is {m.eng}");
            Console.WriteLine($"last name is {m.tam}");
            Console.WriteLine($"email is {m.maths}");
            Console.WriteLine($"age is {m.science}");
            Console.WriteLine($"mobilenumber is {m.social}");
        }
        public constructor1 Info()
        {
            constructor1 obj1 = new constructor1();

            Console.WriteLine("enter the eng marks ");
            obj1.eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the tam marks");
            obj1.tam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the  maths marks");
            obj1.maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the science marks age");
            obj1.science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the social marks");
            obj1.social = Convert.ToInt32(Console.ReadLine());
            return obj1;
        }
    }


        

    

    
}
