using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SSPOdenseMenu
{
    public class UserReport
    {
        private static string connectionString = 
            "Server=EALSQL1.eal.local; Database= C_DB13_2018; User Id=C_STUDENT13; Password=C_OPENDB13;";

        public void Connect()
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    Console.WriteLine("Tryk enter for at indbrette en anmeldese:");
                    Console.ReadLine();

                    SqlCommand cmd1 = new SqlCommand("InsertUserReport", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    string stringInputUserID = Console.ReadLine();
                    int.TryParse(stringInputUserID, out int intInputUserID);
                    cmd1.Parameters.Add(new SqlParameter("@UserID", intInputUserID));
                    Console.WriteLine("indtast datetime");
                    string stringInputDateTime =  Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@DateTime", stringInputDateTime));
                    Console.WriteLine("Indtast lokation");
                    string stringInputLocation = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@Location", stringInputLocation));
                    Console.WriteLine("indtast anmeldelse");
                    string stringInputReportText = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@ReportText", stringInputReportText));

                    cmd1.ExecuteNonQuery();
                }
                catch(SqlException e)
                {
                    Console.WriteLine("wtf: " + e.Message);
                }
            }
        }
    }
}
