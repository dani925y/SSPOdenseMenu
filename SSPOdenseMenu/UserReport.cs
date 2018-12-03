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
            "Server = EALSQL1.eal.local; Database = C_DB13_2018; User Id = C_STUDENT13; Password = C_OPENDB13;";

        public void Connect()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("InsertUserReport", con);
                }
                catch
                {
                    throw new Exception("wtf");
                }
            }
        }
    }
}
