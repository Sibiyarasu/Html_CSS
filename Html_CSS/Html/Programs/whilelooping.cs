using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class whilelooping
    {
        int count;
        
        string b = "Sibiyarasu@Gmail.Com";
      //  char[] b = new char[] { 'a', 'e', 'i', 'o', 'u' };
        public void tochkvowel()
        {

         
            b = b.ToLower();

            int a = 0;
            while (a < b.Length)
            {
                if (b[a] == 'a' || b[a] == 'e' || b[a] == 'i' || b[a] == 'o' || b[a] == 'u')
                {
                    count++;
                    Console.WriteLine(b[a]);

                    
                }

                a++;
            }

          //  Console.WriteLine(count);
           // Console.WriteLine(count.Length);

        }

    }



}
