using System;
using System.Collections.Generic;
using System.Text;

namespace FvKalk
{
    internal class SimpleMenu
    {
        public static void StartSimpleMenu()
        {
            Console.Title = "Simple Menu";

            while (true)
            {
                Console.Clear();

                Console.WriteLine(">>> Instance of menu <<<");
                Console.WriteLine("1 - First option");
                Console.WriteLine("2 - Second option");
                Console.WriteLine("3 - End");

                ConsoleKeyInfo character = Console.ReadKey();
                switch (character.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); InWorks(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); InWorks(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0); break;
                    default: break;
                }
            }
        }

        static void InWorks()
        {            
            Console.WriteLine("Page is in works");
            Console.ReadKey();
        }
    }
}
