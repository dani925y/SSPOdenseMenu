using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOdenseMenu
{
    public class Controller
    {
        public void Report()
        {
            UserReport n = new UserReport();

            n.Connect();
        }

        public void Login()
        {
            Console.Clear();
            Console.WriteLine("Brugernavn: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Password: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Haha bare det virkede");
        }

        public void CreateUser()
        {
            InsertUser user = new InsertUser();

            user.ConnectToUserDatabase();
        }

        public void CheckDB()
        {
            ShowReports show = new ShowReports();

            show.PullFromDB();
        }

    }
}
