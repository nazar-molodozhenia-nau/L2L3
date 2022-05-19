namespace Main {
    public class Owner : IObserver{

        public bool IsAnimal { get; set; }

        public Animal Animal { get; set; }

        public void Subscribe(IAnimal animal) {

            // State.

            animal.NotifyAboutLifeState += StateNotification.LifeNotification;
            animal.NotifyAboutEating += StateNotification.EatNotification;
            animal.NotifyAboutHappyState += StateNotification.HappyNotification;
            animal.NotifyAboutUnHappyState += StateNotification.UnHappyNotification;
            animal.NotifyAboutCleanState += StateNotification.CleanNotification;
            animal.NotifyAboutWill += StateNotification.AtLargeNotification;
            animal.NotifyAboutNotWill += StateNotification.AtNotLargeNotification;
            animal.NotifyAboutSell += StateNotification.SellNotification;

            // Move.

            animal.NotifyAboutWalking += MoveNotification.WalkNotification;
            animal.NotifyAboutRunning += MoveNotification.RunNotification;
            animal.NotifyAboutCrawling += MoveNotification.CrawlNotification;
            animal.NotifyAboutFlying += MoveNotification.FlyNotification;

            animal.NotifyAboutSpeaking += MoveNotification.SpeakNotification;
        }

        public void Unsubscribe(IAnimal animal) {

            // State.

            animal.NotifyAboutLifeState -= StateNotification.LifeNotification;
            animal.NotifyAboutEating -= StateNotification.EatNotification;
            animal.NotifyAboutHappyState -= StateNotification.HappyNotification;
            animal.NotifyAboutUnHappyState -= StateNotification.UnHappyNotification;
            animal.NotifyAboutCleanState -= StateNotification.CleanNotification;
            animal.NotifyAboutWill -= StateNotification.AtLargeNotification;
            animal.NotifyAboutNotWill += StateNotification.AtNotLargeNotification;
            animal.NotifyAboutSell += StateNotification.SellNotification;
            animal.NotifyAboutHungryState -= StateNotification.HungerNotification;
            animal.NotifyAboutNotHungryState -= StateNotification.NotHungerNotification;

            // Hours.

            animal.NotifyAboutHoursForNextMeal -= HoursNotification.HoursForNextMealNotification;
            animal.NotifyAboutHoursOfHunger -= HoursNotification.HoursOfHungerNotification;

            // Move.

            animal.NotifyAboutWalking -= MoveNotification.WalkNotification;
            animal.NotifyAboutRunning -= MoveNotification.RunNotification;
            animal.NotifyAboutCrawling -= MoveNotification.CrawlNotification;
            animal.NotifyAboutFlying -= MoveNotification.FlyNotification;

            animal.NotifyAboutSpeaking -= MoveNotification.SpeakNotification;
        }

        public bool IsReceive { get; set; } = false;

        public void ReceiveMessageAboutHungerOfAnimal(IAnimal animal) {
            animal.NotifyAboutHoursForNextMeal += HoursNotification.HoursForNextMealNotification;
            animal.NotifyAboutHoursOfHunger += HoursNotification.HoursOfHungerNotification;

            animal.NotifyAboutHungryState += StateNotification.HungerNotification;
            animal.NotifyAboutNotHungryState += StateNotification.NotHungerNotification;
        }

        public void NotReceiveMessageAboutHungerOfAnimal(IAnimal animal) {
            animal.NotifyAboutHungryState -= StateNotification.HungerNotification;
            animal.NotifyAboutNotHungryState -= StateNotification.NotHungerNotification;

            animal.NotifyAboutHoursForNextMeal -= HoursNotification.HoursForNextMealNotification;
            animal.NotifyAboutHoursOfHunger -= HoursNotification.HoursOfHungerNotification;
        }

    }
}