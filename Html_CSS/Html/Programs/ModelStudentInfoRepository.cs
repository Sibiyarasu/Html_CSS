using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace SibiConsole
{
    public class ModelStudentInfoRepository
    {

        public int empid { get; set; }
        public string name { get; set; }
        public string place { get; set; }
        public int mobile { get; set; }

    }



    public class studentInfoRepository

    {
        public readonly string conectionstring;

        public ModelStudentInfoRepository modelInfo()
        {

            ModelStudentInfoRepository S = new ModelStudentInfoRepository();

            Console.WriteLine("Enter  EMPID");
            S.empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  name");
            S.name = Console.ReadLine();

            Console.WriteLine("Enter  place");
            S.place = Console.ReadLine();


            Console.WriteLine("Enter  mobile");
            S.mobile = Convert.ToInt32(Console.ReadLine());
            return S;
        }

        public studentInfoRepository()
        {
            conectionstring = @"Data source=DESKTOP-TKPKUBE\SQLEXPRESS;Initial catalog=SQL QUERIES;User Id=sa;Password=Anaiyaan@123";
        }
        public void Insert(ModelStudentInfoRepository A)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"insert into dbo.student_info (empid,name,place,mobile) values('{A.empid}','{A.name}','{A.place}','{A.mobile}')");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ModelStudentInfoRepository> Select()

        {

            try

            {

                List<ModelStudentInfoRepository> c = new List<ModelStudentInfoRepository>();
                var connection = new SqlConnection(conectionstring);
                connection.Open();
                c = connection.Query<ModelStudentInfoRepository>("select * from student_info").ToList();

                connection.Close();
                foreach (var a in c)
                {
                    Console.WriteLine($" empid -{a.empid } name- {a.name} place- {a.place}  mobile- {a.mobile}");
                }

                return c;
            }

            catch (Exception ex)

            {

                throw ex;

            }


        }

        public void Delete()
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                Console.WriteLine("enter the delete records");
                var del =Convert.ToInt32( Console.ReadLine());


                con.Open();

                con.Execute($"delete from student_info where empid = '{del}'");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(ModelStudentInfoRepository S)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);
                Console.WriteLine("Enter the  empid for which one you want to Update Records");
                var update = Console.ReadLine();

                con.Open();

                con.Execute($"update STUDENT_INFO set empid='{S.empid}',name= '{S.name}', place='{S.name}',mobile='{S.mobile}' where empid='{update}' ");

                con.Close();
            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            public void CURD()
            {
                int a;

                do
                {

                    Console.WriteLine("Choose a option");
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.List");
                    Console.WriteLine("3.Delete");
                    Console.WriteLine("4.Update");
                Console.WriteLine("5.InsertSP");
                Console.WriteLine("6.SelectSP");
                Console.WriteLine("7.DeleteSP");
                Console.WriteLine("8.UpdateSP");

                a = Convert.ToInt32(Console.ReadLine());


                    switch (a)
                    {
                        case 1:


                            studentInfoRepository obj = new studentInfoRepository();
                            var SIBI = obj.modelInfo();
                            obj.Insert(SIBI);
                            break;
                        case 2:
                            studentInfoRepository obj1 = new studentInfoRepository();

                            obj1.Select();

                            break;

                        case 3:
                            studentInfoRepository obj2 = new studentInfoRepository();
                            obj2.Delete();
                            break;

                        case 4:

                            studentInfoRepository obj3 = new studentInfoRepository();
                            var update = obj3.modelInfo();
                            obj3.Update(update);

                            break;

                        default:

                            Console.WriteLine("You are choosing a wrong option for CRUD Operation please select the option any one option from 1 to 4");
                            break;
                    }

                } while (a != 0);








            }

        }
    }









