using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        // displays a menu that loops until the user chooses to exit
        private static void MainMenu()
        {
            int selection = 0; // default selection

            while (selection != 2)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("*                              *");
                Console.WriteLine("*  1. Display Grades           *");
                Console.WriteLine("*  2. Exit                     *");
                Console.WriteLine("*                              *");
                Console.WriteLine("********************************");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());

                    if (selection == 1)
                    {
                        Console.Write("Enter the filename: ");
                        ReadFile(Console.ReadLine());
                    }
                    else if (selection == 2)
                    {
                        Console.WriteLine("Exiting the program...");
                    }
                }
                catch (Exception)
                {
                    selection = 0;
                    Console.WriteLine("Error: Enter a valid input.");
                }

                WaitForKey();
                Console.Clear(); // Clears the screen
            }
        }

        // reads a file and displays the result to the console
        private static void ReadFile(string fileName)
        {
            string[] results = new string[10];
            string appDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            try
            {
                FileStream inFile = new FileStream(appDir + "\\Data\\" + fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);

                for (int i = 0; i < 10; i++)
                {
                    string[] line = reader.ReadLine().Split(',');

                    results[i] += line[0].Split(' ')[1] + ", " + line[0].Split(' ')[0] + ": "; //first and last name
                    results[i] += line[1] + ' ' + line[2] + ", "; //course code and name;
                    results[i] += line[3]; //course grade
                }

                reader.Close(); //closes the file
                inFile.Close(); //closes the file-stream

                foreach (string line in results)
                {
                   Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: No such file.");
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
