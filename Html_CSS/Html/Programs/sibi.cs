using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class sibi
    {
        public string name;
        public string qualification;
        public int age;


        public void GetUserInfoMethod()
        {
            //rpivate variable
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Qualification");
            string qualification = Console.ReadLine();

            this.name = name;
            this.age = age;
            this.qualification = qualification;

            Console.WriteLine($"Name:{name} -> Age:{age} -> Qualification: {qualification}");

        }


        public void GlobalVariable()
        {

            Console.WriteLine($"Name:{name} -> Age:{age} -> Qualification: {qualification}");
        }


        public void GetUserInfoMethod(string name, int age, string quali)
        {
            this.name = name;
            this.age = age;
            this.qualification = quali;

            Console.WriteLine($"Name:{name} -> Age:{age} -> Qualification: {qualification}");
        }

    }
}
