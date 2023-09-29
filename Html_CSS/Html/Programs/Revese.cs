
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SibiConsole
{
    class Revese
    {
        string a;
        string reverse;

        public void tochkreverse()
        {
            Console.WriteLine("Enter a letter");
            string a = Convert.ToString(Console.ReadLine());

            for(int i=a.Length-1;i>=0 ;i--)
            {
                reverse = reverse + a[i];

            }
            Console.WriteLine(reverse);

        }
    }

}
