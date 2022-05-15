using System;

namespace Main {
    class HoursNotification {

        public static void HoursOfHungerNotification(Animal animal) {
            Console.WriteLine("Тварина голодна протягом: " + animal.HoursOfHunger + " год.");
        }

        public static void HoursForNextMealNotification(Animal animal) {
            Console.WriteLine("Наступний прийом їжi через: " + animal.HoursForNextMeal + " год.");
        }

    }
}