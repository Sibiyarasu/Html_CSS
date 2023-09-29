using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace SibiConsole
{
    public class DrivenMenuSP
    {


        public int player_id { get; set; }
        public string player_name { get; set; }
        public string game { get; set; }
        public int player_salary { get; set; }

        public int age { get; set; }

    }

    public class PlayerSP

    {
        public readonly string conectionstring;

        public DrivenMenuSP SP()
        {

            DrivenMenuSP S = new DrivenMenuSP();

            Console.WriteLine("Enter  playerid");
            S.player_id = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter  playername");
            S.player_name = Console.ReadLine();

            Console.WriteLine("Enter  game");
            S.game = Console.ReadLine();


            Console.WriteLine("Enter  player salary");
            S.player_salary = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter  player age");
            S.age = Convert.ToInt32(Console.ReadLine());
            return S;
        }

        public PlayerSP()
        {
            conectionstring = @"Data source=DESKTOP-TKPKUBE\SQLEXPRESS;Initial catalog=SQL QUERIES;User Id=sa;Password=Anaiyaan@123";
        }

        public List<DrivenMenuSP> Select()

        {

            try

            {

                List<DrivenMenuSP> c = new List<DrivenMenuSP>();
                var connection = new SqlConnection(conectionstring);
                connection.Open();
                c = connection.Query<DrivenMenuSP>("select * from players").ToList();

                connection.Close();
                foreach (var a in c)
                {
                    Console.WriteLine($" player id - {a.player_id }  player name - {a.player_name}    game - {a.game}  salary - {a.player_salary} age - {a.age}");
                }

                return c;
            }

            catch (Exception ex)

            {

                throw ex;

            }
        }
        public void Insert(DrivenMenuSP A)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"exec insertsp {A.player_id},'{A.player_name}','{A.game}',{A.player_salary},{A.age}");

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

        public void Delete()
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                Console.WriteLine("enter the delete player id");
                var del = Convert.ToInt32(Console.ReadLine());


                con.Open();

                con.Execute($"exec deletesp {del}");

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
        public void Update()
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);
                Console.WriteLine("Enter  player name");
                var player_name = Console.ReadLine();

                Console.WriteLine("Enter  player game");
                var game = Console.ReadLine();


                Console.WriteLine("Enter  player salary");
                var player_salary = Console.ReadLine();


                Console.WriteLine("Enter  player age");
                var age = Console.ReadLine();

                Console.WriteLine("Enter the  playerid for which one you want to Update Records");
                var player_id = Console.ReadLine();
                




                con.Open();

                con.Execute($"exec updatesp '{player_name}',{game},{player_salary},{age},{player_id} ");

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



        public void CURDSP()
        {
            int a;

            do
            {

                Console.WriteLine("Choose a option");

                Console.WriteLine("1.SelectSP");
                Console.WriteLine("2.InsertSP");
                Console.WriteLine("3.DeleteSP");
                Console.WriteLine("4.UpdateSP");

                a = Convert.ToInt32(Console.ReadLine());


                switch (a)
                {
                    case 1:


                        PlayerSP obj = new PlayerSP();
                        obj.Select();
                        break;
                    case 2:
                        PlayerSP obj1 = new PlayerSP();

                        var SIBI = obj1.SP();
                        obj1.Insert(SIBI);
                        break;

                    case 3:
                        PlayerSP obj3 = new PlayerSP();
                        obj3.Delete();
                        break;

                    case 4:

                        PlayerSP obj4 = new PlayerSP();
                        
                        obj4.Update ();

                        break;

                    default:

                        Console.WriteLine("You are choosing a wrong option for CRUD Operation please select the option any one option from 1 to 4");
                        break;
                }

            } while (a != 0);


        }
    }
}

