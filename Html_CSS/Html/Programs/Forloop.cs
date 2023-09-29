 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class Forloop
    {
        public void add()
        {
            for (int b = 100; b > 0; b--)
                if (b % 2 == 0)
                {
                    Console.WriteLine(b);
                }
        }
    }
    class forloop1
    {
        public void arrayadd()
        {
            
            Console.WriteLine("ENTER THE SIZE OF THE ARRAY");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];

            for(int b=0;b<a.Length;b++)
            {
                Console.WriteLine("Enter the value");
                a[b] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]);
                temp = temp + a[i];

            }

            Console.WriteLine(temp);
        }

    }
    class ternary
    { 
        public void  ternary1()
        { 
            var b = 10;
            var a = (b > 5) ? "true" : "FALSE";
            Console.WriteLine(a);
        }
        
        
    }
    class looping
    {
        public void addarray()
        {
            int[] a = new int[] { 10, 20, 34, 45 };

            int temp = 0;

            for(int i =0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
                temp = temp + a[i];
            }
            Console.WriteLine(temp);
        }
    }
}