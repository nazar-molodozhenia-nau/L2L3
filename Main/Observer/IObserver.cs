namespace Main {
    public interface IObserver {

        void Subscribe(IAnimal animal);
        void Unsubscribe(IAnimal animal);

        void ReceiveMessageAboutHungerOfAnimal(IAnimal animal);
        void NotReceiveMessageAboutHungerOfAnimal(IAnimal animal);

    }
}