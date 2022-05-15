namespace Main {
    public class LifeState : IAnimalLifeState {

        public bool Life(Animal animal) { animal.LifeState = new LifeState(); return true; }

        public void ChangeLifeState(Animal animal) { animal.LifeState = new DieState(); }

    }
}