using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SSPOdenseMenu
{
    public class TjekDB
    {
        private static string connectionString =
            "Server=EALSQL1.eal.local; Database= C_DB13_2018; User Id=C_STUDENT13; Password=C_OPENDB13;";

        public void PullFromDB()
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("GetStuff", con);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string datetime = reader["DateTime"].ToString();
                            string location = reader["Location"].ToString();
                            string reporttext = reader["ReportText"].ToString();
                            Console.WriteLine($"{datetime} {location} {reporttext}");
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Fejl: " + e.Message);
                }
            }
        }
    }
}


