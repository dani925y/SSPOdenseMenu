using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOdenseMenu
{
    public class Menu
    {
        Controller control = new Controller();
        public void Show()
        {
            bool active = true;
            do
            {
                ShowMenu();
                int input = GetUserInput();
                switch (input)
                {
                    case 0:
                        active = false;
                        break;
                    case 1:
                        Console.Clear();
                        control.Report();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        control.Login();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        control.OpretBruger();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        control.TjekDBForIndhold();
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.Clear();
                        Show();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("hvad fanden laver du?");
                        break;
                }
            } while (active);
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Anmeldelse");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Opret bruger");
            Console.WriteLine("4. Tjek db bromand");
            Console.WriteLine("0. Exit");
        }

        private int GetUserInput()
        {
            Console.WriteLine();
            Console.Write("Vælg menupunkt: ");
            string input = Console.ReadLine();
            int.TryParse(input, out int parsedInput);
            return parsedInput;
        }
    }
}
