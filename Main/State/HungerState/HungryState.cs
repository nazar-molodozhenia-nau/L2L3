namespace Main {
    public class HungryState : IAnimalHungerState {

        public bool Hunger(Animal animal) { animal.HungerState = new HungryState(); return true; }

        public void Eat(Animal animal) { animal.HungerState = new NotHungryState(); }

    }
}