using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
     public class vegetables
    {
        public int  tot_value()
        {
            int apple = 200;
            int orange = 100;
            int tomato = 50;
            int potato = 40;
            int tot_value;

            tot_value = apple * 5 + orange * 3 + tomato * 2 + potato * 4;
            return tot_value; 

        }
    }

    public class vegetables_1

    {
        public void total()
        {
            vegetables obj = new vegetables();
            int value = obj.tot_value();
            Console.WriteLine(value);
        }
    }
}
