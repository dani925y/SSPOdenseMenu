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

        public void OpretBruger()
        {
            Console.Clear();
            Console.WriteLine("Indtast ønsket brugernavn: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Indtast ønsket password: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Indtast post nummeret for dit område");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Haha hvis bare det virkede man");
            Console.ReadLine();
        }

        public void CheckDB()
        {
            ShowReports show = new ShowReports();

            show.PullFromDB();
        }
    }
}
