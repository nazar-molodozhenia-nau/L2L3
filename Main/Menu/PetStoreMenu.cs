using System;

namespace Main {
    public static class PetStoreMenu {

        public static void StartPetStoreMenu(Owner owner) {

            while(true) {

                Console.Clear();
                Console.WriteLine("||-------------------------   Симуляцiя поведiнки тварин!   -------------------------||");
                Console.WriteLine("||---------------------------------   Зоомагазин   ----------------------------------||");
                Console.WriteLine("||-------------------------------   Купити тварину   --------------------------------|| (Натиснiсть \"1\")");
                Console.WriteLine("||------------------------------------   Назад   ------------------------------------|| (Натиснiсть \"ESC\")");

                ConsoleKey key = Console.ReadKey(true).Key;

                switch(key) {
                    case ConsoleKey.D1:

                        if(owner.IsAnimal == true) { 
                            Console.Clear(); 
                            Console.WriteLine("У вас вже є тварина! Ви можете доглядати лише за однією твариною!");
                            Console.ReadKey();
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("||-------------------------   Симуляцiя поведiнки тварин!   -------------------------||");
                        Console.WriteLine("||---------------------------------   Зоомагазин   ----------------------------------||");
                        Console.WriteLine("Оберiть тварину в зоомагазинi: Кіт (Натиснiсть \"1\"); Змія (Натиснiсть \"2\"); Папуга (Натиснiсть \"3\")");

                        ConsoleKey keyAnimal = Console.ReadKey(true).Key;

                        string name;

                        switch(keyAnimal) {
                            case ConsoleKey.D1:
                                Console.Clear();
                                Console.Write("Введiть iм'я тварини: ");
                                name = Console.ReadLine();
                                Cat cat = new Cat(name, ResidenceType.House, 2, 4, true, false);
                                cat.TimeOfLife();
                                owner.Subscribe(cat);
                                owner.IsAnimal = true;
                                owner.Animal = cat;
                                owner.ReceiveMessageAboutHungerOfAnimal(owner.Animal);
                                Console.WriteLine("Тварина названа та куплена!");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D2:
                                Console.Clear();
                                Console.Write("Введiть iм'я тварини: ");
                                name = Console.ReadLine();
                                Snake snake = new Snake(name, ResidenceType.House, 2, 0, true, false);
                                snake.TimeOfLife();
                                owner.Subscribe(snake);
                                owner.IsAnimal = true;
                                owner.Animal = snake;
                                owner.ReceiveMessageAboutHungerOfAnimal(owner.Animal);
                                Console.WriteLine("Тварина названа та куплена!");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D3:
                                Console.Clear();
                                Console.Write("Введiть iм'я тварини: ");
                                name = Console.ReadLine();
                                Parrot parrot = new Parrot(name, ResidenceType.House, 2, 4, true, false);
                                parrot.TimeOfLife();
                                owner.Subscribe(parrot);
                                owner.IsAnimal = true;
                                owner.Animal = parrot;
                                owner.ReceiveMessageAboutHungerOfAnimal(owner.Animal);
                                Console.WriteLine("Тварина названа та куплена!");
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }

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