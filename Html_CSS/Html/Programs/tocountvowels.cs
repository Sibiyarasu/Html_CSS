using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class A
    {
        string b = "Sibiyarasu";
        string count;
        public void m1()
        {
            b.ToLower();
            for (var a = 0; a < b.Length; a++)
            {
                if( b[a]== 'a' || b[a] == 'e' || b[a] == 'i' || b[a] == 'o' || b[a] == 'u' )
                {

                    count = count + b[a];
                }
                        




            }
            Console.WriteLine(count);
            Console.WriteLine(count.Length);
            // Console.WriteLine(Consonent);

        }
    }
}   

    
 //if (temp.Contains(a[i])) 