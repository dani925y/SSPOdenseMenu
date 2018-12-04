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
            string stringInput = Console.ReadLine();
            int.TryParse(stringInput, out int intInput);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("InsertUserReport", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add(new SqlParameter("@UserID", intInput));
                    Console.WriteLine("indtast userid");
                    Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@DateTime", stringInput));
                    Console.WriteLine("indtast datetime");
                    Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@Location", stringInput));
                    Console.WriteLine("indtast lokation");
                    Console.ReadLine();
                    cmd1.Parameters.Add(new SqlParameter("@ReportText", stringInput));
                    Console.WriteLine("indtast reporttext");
                    Console.ReadLine();

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
