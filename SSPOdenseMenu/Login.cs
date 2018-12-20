using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SSPOdenseMenu
{
    class Login
    {
                    private static string connectionString =
            "Server=EALSQL1.eal.local; Database= C_DB03_2018; User Id=C_STUDENT03; Password=C_OPENDB03;";

        public bool CheckLogin()
        {

            Console.Clear();
            Console.Write("Brugernavn: ");
            string username = Console.ReadLine();
            Console.Write("Kodeord: ");
            string password = ReadPassword();

            return CheckLoginInformation(username, password);
        }

        public bool CheckLoginInformation(string username, string password)
        {
            string query = "SELECT @Username, @Password FROM [UserDatabase] WHERE @Username = '" + username + "' AND @Password = '" + password + "'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("SSPLoginSP", con);

                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.HasRows) return true;
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            return false;
        }



        public string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += key.KeyChar;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    password = password.Substring(0, password.Length - 1);
                    int pos = Console.CursorLeft;
                    Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(pos - 1, Console.CursorTop);
                }
                key = Console.ReadKey(true);
            }
            return password;
        }
    }
}
