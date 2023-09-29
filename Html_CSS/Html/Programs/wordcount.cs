using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class wordcount1
    {
        
        public void tochkwordcount()
        {
            Console.WriteLine("Enter a sentence to count a word ");
            string a =Console.ReadLine();
            a = a.Trim();
            int temp = 0;


            for (var i = 0; i<a.Length;i++)
                {
                if(a[i]==' ')
                {
                    temp++;
                }

            }
            int c = temp + 1;
            Console.WriteLine("The count is   "+ c);
        }

        public void m1()
        {
            Console.WriteLine("Enter a sentence to count a word ");
            string a = Console.ReadLine();
            a = a.Trim();
            var sibi = a.Split(' ');
            Console.WriteLine(sibi.Length);
        }
            
    }
}
