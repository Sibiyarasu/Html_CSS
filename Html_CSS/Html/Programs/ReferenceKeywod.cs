using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class ReferenceKeyword
    {
        public void p1(ref int num)
        {
            num++;
        }
        public void p2()
        {

            int value = 10;
            p1(ref value);
            Console.WriteLine(value);
        }

    }
}
