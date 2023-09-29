using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class SingleInheritance
    {
      

        public void add()
        {
            int a = 5;
            int b = 10;
            int c = a + b;
            Console.WriteLine("addition  is     "+ c);

        }
    }

    class b:SingleInheritance
    {
        
        int aa = 12;

        int bb = 10;
        public void multiply()
        {
            int result = aa * bb;
            Console.WriteLine("result is     "+result);
           

        }
    }
}
