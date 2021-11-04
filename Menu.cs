using System;

namespace EditorHTML
{

    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 25; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 25; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 25; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("HTML Editor");
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("========================");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Select an option below:");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1 - New file");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("2 - Open");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(2, 8);
            Console.Write("Option: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }

            }
        }
    }





}
