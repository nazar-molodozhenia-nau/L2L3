using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    public class Parrot : Animal {

        public Parrot(string name, ResidenceType residenceType, int eyes, int paws, bool tale, bool wings) {
            Name = name;
            ResidenceType = residenceType;
            Eyes = eyes;
            Paws = paws;
            Tale = tale;
            Wings = wings;

            //HungerState = new HungryState();
            //HappinessState = new HappyState();
            //LifeState = new LifeState();
        }

        public override void Move() {

        }

        public override string ToString() { return string.Format($"Parrot: {Name}"); }

    }
}