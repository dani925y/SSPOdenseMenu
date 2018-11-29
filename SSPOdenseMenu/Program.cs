using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOdenseMenu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Run();
        }

        void Run()
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
