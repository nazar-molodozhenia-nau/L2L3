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
        public event StateHandler NotifyAboutNotWill;

        public event StateHandler NotifyAboutSell;

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

        public void Eat() {
            if(LifeState.Life(this)) {
                if(!AtLarge()) {
                    if(HoursForNextMeal == 0) {
                        HungerState.Eat(this);
                        if(NotifyAboutEating != null) { NotifyAboutEating(); }
                        HoursOfHunger = 0;
                        HoursForNextMeal = 3;
                        CountOfMeal++;
                    }
                } else { if(NotifyAboutWill != null) { NotifyAboutWill(); } }
            } else { NotifyAboutLifeState(); }
        }

        public void Hunger() {
            if(LifeState.Life(this)) {
                if(!AtLarge()) {
                    if(HungerState.Hunger(this)) {
                        if(NotifyAboutHungryState != null) { NotifyAboutHungryState(); }
                        if(NotifyAboutHoursOfHunger != null) { NotifyAboutHoursOfHunger(this); }
                    } else {
                        if(NotifyAboutNotHungryState != null) { NotifyAboutNotHungryState(); }
                        if(NotifyAboutHoursForNextMeal != null) { NotifyAboutHoursForNextMeal(this); }
                    }
                } else { if(NotifyAboutWill != null) { NotifyAboutWill(); } }
            } else { if(NotifyAboutLifeState != null) { NotifyAboutLifeState(); } }
        }

        public void Happiness() {
            if(LifeState.Life(this)) {
                if(HappinessState.Happiness(this)) { if(NotifyAboutHappyState != null) { NotifyAboutHappyState(); } } 
                else { if(NotifyAboutUnHappyState != null) { NotifyAboutUnHappyState(); } }
            } else { if(NotifyAboutLifeState != null) { NotifyAboutLifeState(); } }
        }

        public void TimeOfLife() {

            TimerCallback timerCallback = new TimerCallback(Time);
            Timer timer = new Timer(timerCallback, null, 0, 900);

            void Time(object obj) {

                Minutes++;
                if(Clock.Hours >= 23 && Clock.Minutes >= 50 && CountOfCleaning == 0) { HappinessState.ChangeHappinessState(this); }
                if(Minutes == 60) {
                    Minutes = 0;
                    Hours++;
                    if(HoursForNextMeal != 0) { HoursForNextMeal--; } 
                    else { HoursForNextMeal = 0; }
                    HoursOfHunger++;
                    if(Clock.Hours >= 24) { Hours = 0; CountOfMeal = 0; CountOfCleaning = 0; Days++; }
                }

                if((Clock.Hours >= 23 && Clock.Minutes >= 50 && CountOfMeal == 0) || (Clock.Hours >= 23 && Clock.Minutes >= 50 && CountOfMeal >= 3)) {
                    LifeState.ChangeLifeState(this);
                    timer = null;
                }

            }

        }

        public void Cleaning() {
            if(LifeState.Life(this)) {
                if(!AtLarge()) {
                    NotifyAboutCleanState();
                    HappinessState = new HappyState();
                    CountOfCleaning++;
                } else { if(NotifyAboutWill != null) { NotifyAboutWill(); } }
            } else { if(NotifyAboutLifeState != null) { NotifyAboutLifeState(); } }
        }

        public void Release() {
            if(LifeState.Life(this)) {
                ResidenceType = ResidenceType.Street;
                HappinessState = new HappyState();
                if(NotifyAboutWill != null) { NotifyAboutWill(); }
            } else { if(NotifyAboutLifeState != null) { NotifyAboutLifeState(); } }
        }

        public void Return() {
            if(LifeState.Life(this)) {
                ResidenceType = ResidenceType.House;
                HappinessState = new UnHappyState();
                if(NotifyAboutNotWill != null) { NotifyAboutNotWill(); }
            } else { if(NotifyAboutLifeState != null) { NotifyAboutLifeState(); } }
        }

        public void SellAnimal(Owner owner) { if(LifeState.Life(this)) { owner.Animal.NotifyAboutSell(); owner.Unsubscribe(owner.Animal); owner.Animal = null;  owner.IsAnimal = false;  } }

        public bool AtLarge() { if(ResidenceType == ResidenceType.Street) { return true; } return false; }

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