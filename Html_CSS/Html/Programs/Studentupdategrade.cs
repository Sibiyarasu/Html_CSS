 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SibiConsole
{
    
    class stugrade
    {
       public int eng;
       public int tot;
       public int avg;
        //char grade;
        public student_grade   getstudent()

        {
            student_grade s = new student_grade();

           //stugrade s= new stugrade();
            Console.WriteLine("enter your name");
           
            s.name = Console.ReadLine();
            
            
            
            Console.WriteLine("enter your eng mark");
            
            s.english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your tam marks");
            s.tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your maths mark");
            s.maths = Convert.ToInt32(Console.ReadLine());

            return s ;
        } 
        public student_grade [] getstudentinformation()
        {
            student_grade [] student = new student_grade [2];
            student[0] = getstudent();
            student[1] = getstudent();
            return student;
        }
        public char grade(student_grade s)
        {
           
          int  tot = s.english + s.tamil + s.maths;
          int avg = tot / 3;

            char grade = 'F';

          //  stugrade a = new stugrade();
            if (avg >= 91 && avg < 100)
            {
                grade = 'A';// Console.WriteLine("  grade is  A");
            }
            else if (avg >= 81 && avg < 90)
            {
                grade = 'B'; //Console.WriteLine(" grade  is B");

            }
            else if (avg >= 71 && avg < 50)
            {
                grade = 'c';// Console.WriteLine(" grade  is c");

            }
            else if (avg < 50)
            {
                Console.WriteLine("  grade is  D");

            }

            return grade;
        }


        
    }
}
