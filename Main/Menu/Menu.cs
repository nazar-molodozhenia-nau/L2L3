using System;

namespace Main {
    public static class Menu {

        public static void Start() { Console.CursorVisible = false; StartMenu(); }

        private static void StartMenu() {

            while(true) {

                Console.Clear();
                Console.WriteLine("||-------------------------   Симуляцiя поведiнки тварин!   -------------------------||");
                Console.WriteLine("||-----------------------------------   Будинок   -----------------------------------|| (Натиснiсть \"1\")");
                Console.WriteLine("||---------------------------------   Зоомагазин)   ---------------------------------|| (Натиснiсть \"2\")");
                Console.WriteLine("||------------------------------------   Вихід   ------------------------------------|| (Натиснiсть \"3\")");

                ConsoleKey key = Console.ReadKey(true).Key;

                switch(key) {
                    case ConsoleKey.D1:
                        //
                        break;
                    case ConsoleKey.D2:
                        //
                        break;
                    case ConsoleKey.D3:
                        return;
                    default:
                        break;
                }

            }

        }

    }
}