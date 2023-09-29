 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    class student_grade
    {
        public string name;
        public int english;
        public int tamil;
        public int maths;
        public int science;
        public int social;
        public int total;
        public char grade;
    }
    class gradesystem
    {
        public void student1()
        {

            student_grade[] s = new student_grade[2];

            s[0] = new student_grade();
            s[0].name = "sibi";
            s[0].english = 60;
            s[0].tamil = 60;
            s[0].maths = 95;
            s[0].science = 100;
            s[0].social = 100;


            int total = s[0].english + s[0].tamil + s[0].maths + s[0].science + s[0].social;
            Console.WriteLine("sibi's total is " + total);

            int avg = total / 5;
            Console.WriteLine("sibi's avg is " + avg);




            if (avg >= 91 && avg < 100)
            {
                Console.WriteLine(" sibi grade is  A");
            }
            else if (avg >= 81 && avg < 90)
            {
                Console.WriteLine("sibi grade  is B");

            }
            else if (avg >= 71 && avg < 50)
            {
                Console.WriteLine("sibi grade  is c");

            }
            else if (avg < 50)
            {
                Console.WriteLine(" sibi grade is  D");

            }
                s[1] = new student_grade();
            s[1].name = "seenu";
            s[1].english = 100;
            s[1].tamil = 100;
            s[1].maths = 100;
            s[1].science = 56;
            s[1].social =100;
             
            
           
            
            int total1 = s[1].english + s[1].tamil + s[1].maths + s[1].science + s[1].social;
            Console.WriteLine("seenu's total is " + total1);


            int avg1 = total1 / 5;
            Console.WriteLine("seenu's avg is " + avg1);



            
            if (avg1 >= 91 && avg1 < 100)
            {
             Console.WriteLine("seenu grade  is A");
            }
            else if (avg1 >= 81 && avg1 < 90)
            {
              Console.WriteLine("seenu grade is  B");

            }
            else if (avg1 >= 71 && avg1 < 50)
            {
              Console.WriteLine("seenu grade is  c");

            }
            else  if (avg1 < 50)
            {
              Console.WriteLine("seenu grade is D");

            }


        }
    }
}
