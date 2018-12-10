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
            string stringInput = Console.ReadLine();
            int.TryParse(stringInput, out int intInput);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("GetStuff", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@UserID", intInput));

                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["UserID"].ToString();
                            string datetime = reader["DateTime"].ToString();
                            string location = reader["Location"].ToString();
                            string reporttext = reader["ReportText"].ToString();
                            string reportid = reader["ReportID"].ToString();
                            Console.WriteLine($"{id} {datetime} {location} {reporttext} {reportid}");
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("wtf: " + e.Message);
                }
            }
        }
    }
}


