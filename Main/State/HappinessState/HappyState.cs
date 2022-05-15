namespace Main {
    public class HappyState : IAnimalHappinessState {

        public bool Happiness(Animal animal) { animal.HappinessState = new HappyState(); return true; }

        public void ChangeHappinessState(Animal animal) { animal.HappinessState = new UnHappyState(); }

    }
}