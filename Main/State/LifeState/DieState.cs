namespace Main {
    public class DieState : IAnimalLifeState {

        public bool Life(Animal animal) { animal.LifeState = new DieState(); return false; }

        public void ChangeLifeState(Animal animal) { animal.LifeState = new DieState(); }

    }
}