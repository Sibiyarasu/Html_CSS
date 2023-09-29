using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    public class Duplicate
    {
       // //static void Main(string[] args)
       //// {

            String a;
            string temp = string.Empty;
            string duplicate = string.Empty;
            int count;
            public  void chkduplicate()
            {

                Console.WriteLine("Enter a name to check duplicate");
                string a = Convert.ToString(Console.ReadLine());
                a = a.ToLower();
                for (int i = 0; i < a.Length; i++)
                {
                    if (temp.Contains(a[i]))





                        if (!(duplicate.Contains(a[i])))
                        {
                            duplicate = duplicate + a[i];
                            count++;
                        }
                        else
                        {
                            temp = temp + a[i];

                        }

                }
                Console.WriteLine("The  duplicate letter  is = " + duplicate);
                Console.WriteLine("Count of the duplicate number is" + count);

            }
        }
    } 
