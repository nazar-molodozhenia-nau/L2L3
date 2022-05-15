using System;

namespace Main {
    public static class HouseMenu {

        public static void StartHouseMenu(Owner owner) {

            while(true) {

                Console.Clear();
                Console.WriteLine("||-------------------------   Симуляцiя поведiнки тварин!   -------------------------||");
                Console.WriteLine("||-----------------------------------   Будинок   -----------------------------------||");
                Console.WriteLine("||-----------------------------------   Тварина   -----------------------------------|| (Натиснiсть \"1\")");
                Console.WriteLine("||-----------------------------   Догляд за твариною   ------------------------------|| (Натиснiсть \"2\")");
                Console.WriteLine("||--------------------------------   Поточний час!   --------------------------------|| (Натиснiсть \"3\")");
                Console.WriteLine("||------------------------------------   Назад   ------------------------------------|| (Натиснiсть \"ESC\")");

                ConsoleKey key = Console.ReadKey(true).Key;

                switch(key) {
                    case ConsoleKey.D1:
                        Console.Clear();
                        if(owner.IsAnimal == true) { Console.WriteLine(owner.Animal.ToString()); } 
                        else { Console.WriteLine("У вас немає тварини!"); }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        if(owner.IsAnimal == true) { AnimalMenu.StartAnimalMenu(owner); } 
                        else { Console.Clear(); Console.WriteLine("У вас немає тварини!"); Console.ReadKey(); }
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.Write("Поточний час: " + Clock.PrintTime());
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        return;
                }

            }

        }

    }
}