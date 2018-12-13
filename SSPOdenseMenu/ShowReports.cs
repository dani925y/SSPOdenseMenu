using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SSPOdenseMenu
{
    public class ShowReports
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

                    SqlCommand cmd2 = new SqlCommand("GetAllReports", con);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string reportid = reader["ReportID"].ToString();
                            string userid = reader["UserID"].ToString();
                            string datetime = reader["DateTime"].ToString();
                            string location = reader["Location"].ToString();
                            string reporttext = reader["ReportText"].ToString();
                            Console.WriteLine($"\nRapportID: {reportid} \nUserID: {userid}\nTidspunkt: {datetime} " +
                                $"\nLokation: {location} \nAnmeldelses tekst: {reporttext}\n");
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


