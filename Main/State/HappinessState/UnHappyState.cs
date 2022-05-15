namespace Main {
    public class UnHappyState : IAnimalHappinessState {

        public bool Happiness(Animal animal) { animal.HappinessState = new UnHappyState(); return false; }

        public void ChangeHappinessState(Animal animal) { animal.HappinessState = new HappyState(); }

    }
}