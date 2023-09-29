using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class totalvalue
    {
        public int uservalue()
        {

            Console.WriteLine("enter weight of apple");
            int appleweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate of apple");
            int applerate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter weight of orange");
            int orangeweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate of orange");
            int orangerate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter weight of tomato ");
            int tomatoweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate of tomato");
            int tomatorate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter weight of potato");
            int poatoweight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate of potato");
            int potatorate = Convert.ToInt32(Console.ReadLine());

            int totalvalue = appleweight * applerate + orangeweight * orangerate + tomatoweight * tomatorate + poatoweight * potatorate;

            return totalvalue;



        }
    }
        public class data


        { 
            public void getvalue()
            {
             totalvalue obj = new totalvalue();

            int amount = obj.uservalue();
            Console.WriteLine(amount);
            }

        }


    
}
