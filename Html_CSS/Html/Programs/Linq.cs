using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class Linq
    {
      

            public void LInqMethods()
            {

                List<string> lst = new List<string>();
                lst.Add("suresh");
                lst.Add("Dhoni");
                lst.Add("Sourav");
                lst.Add("Rahul");
            

                //foreach (string a in lst)
                //{

                //}
                if (lst.Any(a => a == "Sourav" || a == ""))
                {

                }

                var soura = lst.Find(x => x.ToLower() == "sourav".ToLower());

                lst.First(x => x.Contains("S"));

                var re = lst.FirstOrDefault(x => x.Contains("x"));

                if (re != null)
                    re = "";

                var list = lst.Where(x => x == "suresh").ToArray();

                var arryBool = lst.Select(x => x.Contains("S")).ToArray();

                lst.Distinct();
                lst.Min();
                lst.Max();

                lst.ForEach(x =>
                {
                    if (x == "sure")
                        x = "ramesh";

                });

            }

        }


        class Employee
        {
            public string FirstName { get; set; }
            public int? age { get; set; }
        }
    }



