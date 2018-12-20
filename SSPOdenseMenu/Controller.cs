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

        public void UserLogin()
        {
            Login user = new Login();
            user.CheckLogin();
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
