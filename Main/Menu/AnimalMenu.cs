using System;

namespace Main {
    public static class AnimalMenu {

        public static void StartAnimalMenu(Owner owner) {

            while(true) {

                Console.Clear();
                Console.WriteLine("||-------------------------   Симуляцiя поведiнки тварин!   -------------------------||");
                Console.WriteLine("||-----------------------------------   Будинок   -----------------------------------||");
                Console.WriteLine("||-----------------------------   Догляд за твариною   ------------------------------||");
                Console.WriteLine("||--------------------------------   Стан тварини   ---------------------------------|| (Натиснiсть \"1\")");
                Console.WriteLine("||------------------------------   Погудувати тварину   -----------------------------|| (Натиснiсть \"2\")");
                Console.WriteLine("||-----------------------------   Прибрати за твариною   ----------------------------|| (Натиснiсть \"3\")");
                Console.WriteLine("||--------------------------   Вiдпустити тварину на волю   -------------------------|| (Натиснiсть \"4\")");
                Console.WriteLine("||------------------------------   Повернути тварину   ------------------------------|| (Натиснiсть \"5\")");
                Console.WriteLine("||-------------------------------   Продати тварину   -------------------------------|| (Натиснiсть \"6\")");
                Console.WriteLine("||--------------------------------   Поточний час!   --------------------------------|| (Натиснiсть \"7\")");
                Console.WriteLine("||------------------------------------   Назад   ------------------------------------|| (Натиснiсть \"ESC\")");

                ConsoleKey key = Console.ReadKey(true).Key;

                switch(key) {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.Write("Happiness: "); owner.Animal.Happiness();
                        Console.Write("\nMove:\n"); owner.Animal.Move(); Console.WriteLine();
                        Console.Write("Hunger: "); owner.Animal.Hunger();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:

                        Console.Clear();

                        if(owner.Animal.ResidenceType == ResidenceType.Street) { owner.Animal.Eat(); } 
                        else { owner.Animal.Eat(); owner.Animal.Hunger(); }

                        if(owner.Animal.LifeState.Life(owner.Animal)) {
                            if(!owner.Animal.AtLarge()) {
                                Console.WriteLine("Сьогоднi тварину погодовано: " + owner.Animal.CountOfMeal + " раз.");
                            }
                        }

                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:

                        Console.Clear();
                        owner.Animal.Cleaning();

                        if(owner.Animal.LifeState.Life(owner.Animal)) {
                            if(!owner.Animal.AtLarge()) {
                                Console.WriteLine("Сьогоднi за твариною прибрано: " + owner.Animal.CountOfCleaning + " раз.");
                            }
                        }

                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        owner.Animal.Release();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        if(owner.Animal.ResidenceType == ResidenceType.Street) { owner.Animal.Return(); } 
                        else { Console.WriteLine("Тварина вдома."); }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        owner.Animal.SellAnimal(owner);
                        Console.ReadKey();
                        return;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Console.Write("Поточний час: ");
                        Console.WriteLine(Clock.PrintTime());
                        Console.ReadKey();
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