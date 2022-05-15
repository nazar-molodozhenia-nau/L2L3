namespace Main {
    public class Parrot : Animal {

        public Parrot(string name, ResidenceType residenceType, int eyes, int paws, bool tale, bool wings) {
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
                    if(HoursOfHunger >= 8) { EventAboutWalking(); } else { EventAboutFlying(); EventAboutSpeaking(); }
                } else { EventAboutWill(); }
            } else { EventAboutDie(); }
        }

        public override string ToString() { return string.Format($"Parrot: {Name}"); }

    }
}