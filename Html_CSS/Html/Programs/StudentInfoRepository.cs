using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace SibiConsole
{
    public class StudentInfoRepository

    {
        public readonly string conectionstring;

        public StudentInfoRepository()
        {
            conectionstring = @"Data source=DESKTOP-PGRUL4J\SQLEXPRESS;Initial catalog=SQL QUERIES;User Id=sa;Password=Anaiyaan@123";
        }
        public void Insert()
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"insert into dbo.student_info (empid,name,place,mobile) values(5,'kannan','salem',9876123)");

                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
