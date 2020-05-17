using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace MarieZoo.Fish
{
    class Seahorse : Fish, IFeed, IDesign, ISound
    {

        public override string Name()
        {
            return "Sven";
        }

        public override string Predator()
        {
            return "Most bigger fish are a threat to me";
        }

        public override string FunFact()
        {
            return "Seahorses must eat constantly, since fod passes through its digestive system so quickly.";
        }

        public decimal LengthInInches => 0.6m;

        public string Color => "I vary in golden and brown tones";

        public string LegsOrFins => "I have two small fins";

        public string Movement => "You won't find me swimming around a lot as I get exhausted easily and could die from over exhaustion";

        public string FeedMe()
        {
            throw new NotImplementedException();
        }

        public override string GetDiet()
        {
            return "I eat algae and small creatures that live on coral.";
        }

        public string GetMakeSound()
        {
            return "neigh neigh";
        }

        public override int GetNumberOfTeeth()
        {
            return 0;
        }
    }
}
