using System;
using System.Collections.Generic;
using System.Text;

namespace FvKalk
{
    static class Menu
    {
        static string[] _positionsMenu = {"Option 1 - Calculate FV",
                                          "Option 2 - Calculate PV",
                                          "Option 3 - Frictions", 
                                          "Option 4 - Complex Numbers",                                          
                                          "End"};
        static int _activePositionMenu = 0;

        public static void StartMenu()
        {
            Console.Title = "Menu";
            Console.CursorVisible = false;

            while (true)
            {
                ShowMenu();
                ChoseOption();
                RunOption();
            }
        }
        static void ShowMenu()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(">>> Menu <<<");
            Console.WriteLine();

            for (int i = 0; i < _positionsMenu.Length; i++)
            {
                if(i == _activePositionMenu)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0,-35}", _positionsMenu[i]);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else
                {
                    Console.WriteLine(_positionsMenu[i]);
                }
            }
        }
        static void ChoseOption()
        {
            do
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if(klawisz.Key == ConsoleKey.UpArrow)
                {
                    _activePositionMenu = (_activePositionMenu > 0 ) ? _activePositionMenu - 1 : _positionsMenu.Length - 1;
                    ShowMenu();
                }
                else if(klawisz.Key == ConsoleKey.DownArrow)
                {
                    _activePositionMenu = (_activePositionMenu + 1) % _positionsMenu.Length;
                    ShowMenu();
                }
                else if(klawisz.Key == ConsoleKey.Escape)
                {
                    _activePositionMenu = _positionsMenu.Length - 1;
                    break;
                }
                else if(klawisz.Key == ConsoleKey.Enter)
                {
                    break;
                }

            } while (true);
        }
        static void InWorks()
        {
            Console.SetCursorPosition(12, 4);
            Console.WriteLine("Page is in works");
            Console.ReadKey();
        }
        
        static void RunOption()
        {
            switch (_activePositionMenu)
            {
                case 0: Console.Clear(); MethodsToMenu.FV(); break; 
                case 1: Console.Clear(); MethodsToMenu.PV(); break; 
                case 2: Console.Clear(); MethodsToMenu.FrictionOperations(); break; 
                case 3: Console.Clear(); MethodsToMenu.SumComplex(); break;                 
                case 4: Environment.Exit(0); break; 
            }
        }
    }
}
