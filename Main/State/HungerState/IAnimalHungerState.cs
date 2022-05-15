namespace Main {
    public interface IAnimalHungerState {

        bool Hunger(Animal animal);

        void Eat(Animal animal);

    }
}