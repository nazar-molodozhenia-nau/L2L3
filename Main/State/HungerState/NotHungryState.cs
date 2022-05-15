namespace Main {
    public class NotHungryState : IAnimalHungerState {

        public bool Hunger(Animal animal) {
            if(animal.HoursForNextMeal == 0) { animal.HungerState = new HungryState(); return true; }
            animal.HungerState = new NotHungryState();
            return false;
        }

        public void Eat(Animal animal) { animal.HungerState = new NotHungryState(); }

    }
}