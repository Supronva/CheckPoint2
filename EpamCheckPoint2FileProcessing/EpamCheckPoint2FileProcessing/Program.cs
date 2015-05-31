using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamCheckPoint2FileProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_command = "";
            bool Infinity = true;
            while (Infinity)
            {
                Console.WriteLine("Please enter the following command: help ; exit");
                user_command = System.Console.ReadLine();
                Console.WriteLine(new string('=', 65));
                switch (user_command)
                {
                    case "exit":
                        {
                            Infinity = false;
                            break;
                        }
                    case "file":
                        {
                            Console.WriteLine("Enter the path to the file: ");
                            string filePath = Console.ReadLine();
                            Text t = new Text(filePath);
                            Console.ReadKey();
                            break;
                        }
                    case "help":
                        {
                            Console.WriteLine("Team List:");
                            Console.WriteLine(new string('-', 65));
                            Console.WriteLine("file");
                            Console.WriteLine(new string('-', 65));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Your team is not defined, please try again");
                            break;
                        }
                }
            }
        }
    }
}

