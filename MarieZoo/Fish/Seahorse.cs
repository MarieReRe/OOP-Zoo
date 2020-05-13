using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Mammals
{
    class Seahorse : Fish, IFeed, IDesign, IEnvironment, ISound
    {
        public decimal LengthInInches => 0.6m;

        public string Color => "I vary";

        public string LegsOrFins => "I have two small fins";

        public string Movement => throw new NotImplementedException();

        public string Predators => throw new NotImplementedException();

        public string FunFact => throw new NotImplementedException();

        public string FeedMe()
        {
            throw new NotImplementedException();
        }

        public string MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
