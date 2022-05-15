namespace Main {
    public interface IAnimalLifeState {

        bool Life(Animal animal);

        void ChangeLifeState(Animal animal);

    }
}