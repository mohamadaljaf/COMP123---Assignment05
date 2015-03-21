using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // displays a menu that loops until the user chooses to exit
        private static void MainMenu()
        {
            int selection = 0; // default selection

            while (selection != 3)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("*                              *");
                Console.WriteLine("*  1. First class              *");
                Console.WriteLine("*  2. Economy Class            *");
                Console.WriteLine("*  3. Exit                     *");
                Console.WriteLine("*                              *");
                Console.WriteLine("********************************");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    selection = 0;
                }


                WaitForKey();
                Console.Clear(); // Clears the screen
            }
        }

        // pauses the program and waits for the user to continue
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("----------------------------");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
