using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class BreakContinue
    {
        int a=5;
            public void Break()
        {

            for(var i=0;i<5; i++ )
            {
            if(i==2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
