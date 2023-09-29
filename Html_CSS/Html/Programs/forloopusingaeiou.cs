using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class forloopusingaeiou
    {
        // public string  a= "My name is sibi" ;
        string a;
        public void vowelsadd()
        
        {
            // char[] a = new char[] 
            Console.WriteLine("Enter a content to check ");
            string a = Console.ReadLine();
            
            
            a = a.ToLower();
            int temp = 0;
            int temp1 = 0;
            for(var i  =0;i<a.Length;i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                { 
                    Console.WriteLine(a[i]);
                  // Console.WriteLine(temp);

                    temp++;
                }

                else
                {
                    temp1++;
                }
            }

            Console.WriteLine( "voewls  ----------------->" +  temp);
            Console.WriteLine("consonents---------------->"+temp1);

        }

        
    }
}
