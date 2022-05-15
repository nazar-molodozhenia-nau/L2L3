namespace Main {
    public interface IAnimalHappinessState {

        bool Happiness(Animal animal);

        void ChangeHappinessState(Animal animal);

    }
}