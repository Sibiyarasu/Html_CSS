using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class employee
    {
        public string firstname;
        public string lastname;
        public string email;
        public short age;
        public long mobilenumber;

    }
    class parameter
    {
        public void m1(employee e)
        {
            Console.WriteLine($"first name is {e.firstname}");
            Console.WriteLine($"last name is {e.lastname}");
            Console.WriteLine($"email is {e.email}");
            Console.WriteLine($"age is {e.age}");
            Console.WriteLine($"mobilenumber is {e.mobilenumber}");
        }

        public employee Info()
        {
            employee obj1 = new employee();

            Console.WriteLine("enter the first name");
            obj1.firstname = Console.ReadLine();
            Console.WriteLine("enter the last name");
            obj1.lastname = Console.ReadLine();
            Console.WriteLine("enter the  email");
            obj1.email = Console.ReadLine();
            Console.WriteLine("enter the age");
            obj1.age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter the mobile number");
            obj1.mobilenumber = Convert.ToInt64(Console.ReadLine());
            return obj1;
        }


    }
}

