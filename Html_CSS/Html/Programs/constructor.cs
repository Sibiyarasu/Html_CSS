using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class constructor
    {
        int eng;
        int tam;
        int maths;
        int science;
        int social;
        int total;
        int avg;

        public constructor()
        {
            Console.WriteLine("enter eng marks");
            eng= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter tam marks");
            tam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter maths marks");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter science marks");
            science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter social marks");
            social = Convert.ToInt32(Console.ReadLine()); 
             
        }
        public void Tot()

        {
            total = eng + tam + maths + science + social;
            Console.WriteLine(total);

        }
        public void Average()
        {
            avg = total / 5;

            Console.WriteLine(avg);
        }

        

        


            
    }
}
