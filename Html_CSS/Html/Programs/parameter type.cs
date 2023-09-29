using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
   public class parmeter_type
    {
        public string sibi()

        {
            string name = " sibi";
            return name;
        }
    }


    class parameter_type_1

    {
        public void data()

        {
            parmeter_type obj = new parmeter_type();

            string value = obj.sibi();

                Console.WriteLine(value);

            
        }
    }
}

