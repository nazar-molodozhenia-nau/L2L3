using System;

namespace Main {
    class StateNotification {

        public static void HungerNotification() { Console.WriteLine("Тварина зголоднiла."); }
        public static void NotHungerNotification() { Console.WriteLine("Тварина сита."); }
        public static void EatNotification() { Console.WriteLine("Тварину погодовано.");}
        public static void HappyNotification() { Console.WriteLine("Тварина щаслива."); }
        public static void UnHappyNotification() { Console.WriteLine("Тварина не щаслива; за твариною не прибрано."); }
        public static void LifeNotification() { Console.WriteLine("Тварина померла."); }
        public static void CleanNotification() { Console.WriteLine("За твариною прибрано."); }
        public static void AtLargeNotification() { Console.WriteLine("Тварину випущено на волю."); }
        public static void AtNotLargeNotification() { Console.WriteLine("Тварину повернено."); }
        public static void SellNotification() { Console.WriteLine("Тварину продано."); }

    }
}