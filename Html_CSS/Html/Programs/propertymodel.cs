using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class propertymodel
    {
        public string productname { get; set; }
        public int price { get; set; }
        public double netweight { get; set; }
        public string location { get; set; }

    }

    class property
    {
        int count;
        string productname;
        int price;
        public  void chkproperty()
        {
            propertymodel obj = new propertymodel();
            Console.WriteLine("Enter the count to show the property model");
            count = Convert.ToInt32(Console.ReadLine());
            propertymodel[] a = new propertymodel[count];
            for(var i =0; i<a.Length;i++)
            {
                a[i] = new propertymodel();

                Console.WriteLine("enter product name");
                a[i]. productname= Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter procuct price ");
                a[i]. price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter weight");
                a[i].netweight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter location ");
                a[i].location = Convert.ToString(Console.ReadLine());



            }
            for(int s=0;s<a.Length; s++)
            {
                Console.WriteLine("the produt name is  " + a[s].productname);
                Console.WriteLine("the price is  " + a[s].price);
                Console.WriteLine("the netweight is  " + a[s].netweight);
                Console.WriteLine("the location is  " + a[s].location);

            }
        }
    }
}
