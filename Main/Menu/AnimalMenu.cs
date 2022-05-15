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
                Console.WriteLine("||--------------------------------   Поточний час!   --------------------------------|| (Натиснiсть \"5\")");
                Console.WriteLine("||------------------------------------   Назад   ------------------------------------|| (Натиснiсть \"ESC\")");

                ConsoleKey key = Console.ReadKey(true).Key;

                switch(key) {
                    case ConsoleKey.D1:

                        Console.Clear();
                        owner.Animal.Happiness();
                        owner.Animal.Move();
                        owner.Animal.Hunger();
                        Console.WriteLine();

                        Console.WriteLine("||--   Отримувати/не отримувати повiдомлення щодо наступного прийому їжi тварини   --|| (Натиснiсть \"SPACE\")");
                        Console.WriteLine("||------------------------------------   Назад   ------------------------------------|| (Натиснiсть \"anything\")");

                        ConsoleKey keyAnimal = Console.ReadKey(true).Key;

                        if(keyAnimal == ConsoleKey.Spacebar) {
                            Console.Clear();
                            Console.WriteLine("Отримувати повiдомлення про кiлькiсть годин до наступного прийому їжi тварини?");
                            Console.WriteLine("-Так (Натиснiсть \"1\")");
                            Console.WriteLine("-Нi  (Натиснiсть \"2\")");

                            ConsoleKey action = Console.ReadKey(true).Key;

                            if(action == ConsoleKey.D1 && owner.IsReceive == false) { owner.ReceiveMessageAboutHungerOfAnimal(owner.Animal); owner.IsReceive = true; }
                            if(action == ConsoleKey.D2 && owner.IsReceive == true) { owner.NotReceiveMessageAboutHungerOfAnimal(owner.Animal); owner.IsReceive = false; }
                        }

                        break;
                    case ConsoleKey.D2:

                        Console.Clear();
                        owner.Animal.Eat();
                        owner.Animal.Hunger();

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