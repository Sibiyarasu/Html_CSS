using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class ISKeyword
    {

        public void askey()
        {
            var obj = 123;
            if(obj is int )
            {
                Console.WriteLine("ISVALID");
            }
            else
            {
                Console.WriteLine("IS NOT VALID");
            }
        }
    }
}
