using System.Threading;

namespace Main {
    public abstract class Animal : IAnimal {

        // List Events

        public event StateHandler NotifyAboutLifeState;

        public event StateHandler NotifyAboutHungryState;
        public event StateHandler NotifyAboutNotHungryState;
        public event StateHandler NotifyAboutEating;

        public event StateHandler NotifyAboutHappyState;
        public event StateHandler NotifyAboutUnHappyState;

        public event StateHandler NotifyAboutCleanState;
        public event StateHandler NotifyAboutWill;

        public event MoveHandler NotifyAboutWalking;
        public event MoveHandler NotifyAboutRunning;
        public event MoveHandler NotifyAboutSinging;
        public event MoveHandler NotifyAboutFlying;
        public event MoveHandler NotifyAboutCrawling;

        public event HoursHandler NotifyAboutHoursOfHunger;
        public event HoursHandler NotifyAboutHoursForNextMeal;

        // Interface States

        public IAnimalLifeState LifeState { get; set; }
        public IAnimalHappinessState HappinessState { get; set; }
        public IAnimalHungerState HungerState { get; set; }

        // Variables

        public int HoursOfHunger { get; private set; }
        public int HoursForNextMeal { get; private set; }
        public int CountOfMeal { get; private set; }
        public int CountOfCleaning { get; private set; }

        protected int Hours { get; set; }
        protected int Minutes { get; set; }
        protected int Days { get; set; }
       
    }
}