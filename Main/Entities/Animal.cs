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
        public event MoveHandler NotifyAboutCrawling;
        public event MoveHandler NotifyAboutFlying;

        public event MoveHandler NotifyAboutSpeaking;

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

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Days { get; set; }

        // Variables in Constructor

        public string Name { get; set; }
        public ResidenceType ResidenceType { get; set; }
        public int Eyes { get; set; }
        public int Paws { get; set; }
        public bool Tale { get; set; }
        public bool Wings { get; set; }

        // Button

        public string Button { get; set; }

        // Methods

        public abstract void Move();

        // Methods for Events

        protected void EventAboutDie() { NotifyAboutLifeState?.Invoke(); }
        protected void EventAboutWill() { NotifyAboutWill?.Invoke(); }

        protected void EventAboutWalking() { NotifyAboutWalking?.Invoke(); }
        protected void EventAboutRunning() { NotifyAboutRunning?.Invoke(); }
        protected void EventAboutCrawling() { NotifyAboutCrawling?.Invoke(); }
        protected void EventAboutFlying() { NotifyAboutFlying?.Invoke(); }

        protected void EventAboutSpeaking() { NotifyAboutSpeaking?.Invoke(); }

    }
}