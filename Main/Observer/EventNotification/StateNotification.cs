using System;
using System.Threading;

namespace Main {
    class StateNotification {

        public static void HungerNotification() { Console.WriteLine("Тварина зголоднiла."); }
        public static void NotHungerNotification() { Console.WriteLine("Тварина сита."); }
        
        public static void EatNotification() {
            Console.WriteLine("Тварина їсть.");
            for(int i = 0; i < 8; i++) { Console.Write('.'); Thread.Sleep(200); }
            Console.WriteLine("\nТварину погодовано.");
        }

        public static void HappyNotification() { Console.WriteLine("Тварина щаслива."); }

        public static void UnHappyNotification() { Console.WriteLine("Тварина не щаслива; за твариною не прибрано."); }
        public static void LifeNotification() { Console.WriteLine("Тварина померла."); }

        public static void CleanNotification() {
            Console.WriteLine("За твариною прибирається.");
            for(int i = 0; i < 8; i++) { Console.Write('.'); Thread.Sleep(200); }
            Console.WriteLine("\nЗа твариною прибрано.");
        }

        public static void AtLargeNotification() { Console.WriteLine("Тварину випущено на волю."); }

    }
}