using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SSPOdenseMenu
{
    public class InsertUser
    {
        private static string connectionString =
            "Server=EALSQL1.eal.local; Database= C_DB03_2018; User Id=C_STUDENT03; Password=C_OPENDB03;";

        public void ConnectToUserDatabase()
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();


                    SqlCommand cmd1 = new SqlCommand("InsertUser", con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Indtast ønsket brugernavn");
                    string stringInputUserID = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@Username", stringInputUserID));
                    Console.Clear();

                    Console.WriteLine("Indtast din ønskede kode");
                    string stringInputDateTime = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@Password", stringInputDateTime));
                    Console.Clear();

                    Console.WriteLine("Hvis du vil modtage et nyhedsbrev for dit område, så indtast dit postnummer");
                    string stringInputLocation = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@Zipcode", stringInputLocation));
                    Console.Clear();

                    Console.WriteLine("Din bruger er nu oprettet - tryk enter for at komme tilbage til menuen");
                    Console.Write("Tryk enter for at afslutte");


                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
    }
}

