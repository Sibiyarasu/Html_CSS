using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class WordReverse
    {

      public  string a;

        public void PrintWordReverse()
        {
            Console.WriteLine("Enter the word");
            string a = Convert.ToString( Console.ReadLine());
            string[] result = a.Split(" ");
            for(int i=result.Length-1;i>=0;i--)
            {
                Console.Write (result[i]+" ");
            }
        }
    }
}
