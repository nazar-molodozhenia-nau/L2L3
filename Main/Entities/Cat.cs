namespace Main {
    public class Cat : Animal {

        public Cat(string name, ResidenceType residenceType, int eyes, int paws, bool tale, bool wings) {
            Name = name;
            ResidenceType = residenceType;
            Eyes = eyes;
            Paws = paws;
            Tale = tale;
            Wings = wings;

            HungerState = new HungryState();
            HappinessState = new HappyState();
            LifeState = new LifeState();
        }

        public override void Move() {
            if(LifeState.Life(this)) {
                if(!AtLarge()) {
                    if(HoursOfHunger >= 8) { EventAboutWalking(); } 
                    else { EventAboutRunning(); }
                } else { EventAboutWill(); }
            } else { EventAboutDie(); }
        }

        public override string ToString() { return string.Format($"Cat: {Name}"); }

    }
}