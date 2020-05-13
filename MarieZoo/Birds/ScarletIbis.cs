using MarieZoo.Interfaces;
using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Birds
{
    public class ScarletIbis : Bird, IDesign, IEnvironment, IFeed, ISound
    {
        public decimal LengthInInches => 17;

        public string Color => "Neon pink with black wing tips";

        public string LegsOrFins => "Two neon pink thin, straw-like legs";

        public string Movement => "Walking and flying around the shorelines of Trinidad";

        public string Predators => "We are hunted for bushmeat";

        public string FunFact => "We are listed as an environmentally sensitive species";

        public override string ColorOfEggs()
        {
           return "we lay pale green eggs that have brown streaks";
        }

        public string FeedMe()
        {
            return "Please purchase us live shrimp from the counter, those are our favorite snacks";
        }

        public string GetMakeSound()
        {
           return "cutest bird noise ever!";
        }

        public override string NestingHabits()
        {
           return "We build our nests in trees";
        }
    }
}
