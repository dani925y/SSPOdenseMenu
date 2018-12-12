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


                    SqlCommand cmd1 = new SqlCommand("InsertUserReport", con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Indtast dit brugernavn - det du logger ind med eller ingenting");
                    string stringInputUserID = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@UserID", stringInputUserID));
                    Console.Clear();

                    Console.WriteLine("Indtast dato - indtast som dd/mm/yyyy");
                    string stringInputDateTime =  Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@DateTime", stringInputDateTime));
                    Console.Clear();

                    Console.WriteLine("Indtast lokation - kan f.eks. være en adresse eller et område");
                    string stringInputLocation = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@Location", stringInputLocation));
                    Console.Clear();

                    Console.WriteLine("Anmeldelse - beskriv hændelsen");
                    string stringInputReportText = Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@ReportText", stringInputReportText));
                    Console.Clear();

                    Console.WriteLine("Tak for din anmeldelse - vi tjekker op på den :)");
                    Console.Write("Tryk enter for at afslutte");


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
