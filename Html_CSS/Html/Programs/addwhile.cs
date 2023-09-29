using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class addwhile
    {
        int total;
        public void addarray()
        {
            int[] a = new int[] { 10, 20 };

            int i = 0;            //while ( i < a.Length )
            for( i=0;i<=a.Length ;i++ )
            {
                total = total+ a[i];


                Console.WriteLine(total); 
                i++;
            }

        }
    }
}

