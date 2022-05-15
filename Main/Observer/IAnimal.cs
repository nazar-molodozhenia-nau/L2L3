namespace Main {

    public delegate void StateHandler();
    public delegate void MoveHandler();
    public delegate void HoursHandler(Animal animal);

    public interface IAnimal {

        event StateHandler NotifyAboutLifeState;

        event StateHandler NotifyAboutHungryState;
        event StateHandler NotifyAboutNotHungryState;
        event StateHandler NotifyAboutEating;

        event StateHandler NotifyAboutHappyState;
        event StateHandler NotifyAboutUnHappyState;

        event StateHandler NotifyAboutCleanState;
        event StateHandler NotifyAboutWill;

        event MoveHandler NotifyAboutWalking;
        event MoveHandler NotifyAboutRunning;
        event MoveHandler NotifyAboutSinging;
        event MoveHandler NotifyAboutFlying;
        event MoveHandler NotifyAboutCrawling;

        event HoursHandler NotifyAboutHoursOfHunger;
        event HoursHandler NotifyAboutHoursForNextMeal;

    }
}