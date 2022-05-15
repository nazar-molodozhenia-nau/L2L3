using System;

namespace Main {
    public static class Menu {

        private static readonly Owner owner = new Owner();

        public static void Start() { Console.CursorVisible = false; StartMenu(); }

        private static void StartMenu() {

            while(true) {

                Console.Clear();
                Console.WriteLine("||-------------------------   Симуляцiя поведiнки тварин!   -------------------------||");
                Console.WriteLine("||-----------------------------------   Будинок   -----------------------------------|| (Натиснiсть \"1\")");
                Console.WriteLine("||---------------------------------   Зоомагазин)   ---------------------------------|| (Натиснiсть \"2\")");
                Console.WriteLine("||------------------------------------   Вихід   ------------------------------------|| (Натиснiсть \"ESC\")");

                ConsoleKey key = Console.ReadKey(true).Key;

                switch(key) {
                    case ConsoleKey.D1:
                        HouseMenu.StartHouseMenu(owner);
                        break;
                    case ConsoleKey.D2:
                        PetStoreMenu.StartPetStoreMenu(owner);
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }

            }

        }

    }
}