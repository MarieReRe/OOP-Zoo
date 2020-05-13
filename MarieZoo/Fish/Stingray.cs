using MarieZoo.Interfaces;
using MarieZoo.Mammals;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MarieZoo.Fish
{

    //CONCRETE CLASS
    class Stingray : Fish, IFeed, ISound, IDesign, IEnvironment
    {
        
        public decimal LengthInInches => 15;

        public string Color => "Royal blue with ivory white spots to reflect the sea floors shading to protect me from my preditors.";

        public string LegsOrFins => "I have two powerful fins that let me glide through the open ocean";

        public string Predators => "I am prone to attack by larger rays and a wide variety of sharks";

        public string Movement => " We undulate like a wave or flap our fins/sides like wings";

        string IEnvironment.FunFact => "Ancient Greek dentists used the venom from the sting ray's spine as an anesthetic";

        public override string GetDiet()
        {
            return "I love eating squid and molusks";
        }

        public override int GetNumberOfTeeth()
        {
            return 0;
        }

        string IFeed.FeedMe()
        {
            return "Squid for $1, we're hungry!";
        }

    
        string ISound.GetMakeSound()
        {
            return "blub blub";
        }
    }
}
