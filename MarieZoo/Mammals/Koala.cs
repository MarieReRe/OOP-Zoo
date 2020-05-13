using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Mammals

{
    public class Koala : Mammals, IDesign, IEnvironment, IFeed, ISound
    {
        public override string Name { get; set; }
        public decimal LengthInInches => 30;

        public string Color => throw new NotImplementedException();

        public string LegsOrFins => throw new NotImplementedException();

        public string Movement => throw new NotImplementedException();

        public string Predators => throw new NotImplementedException();

        public string FunFact => throw new NotImplementedException();

        public override int GetAge()
        {
            return 1;
        }

     

        public override int GetWeight()
        {
            return 30; ;
        }

        
    }
}
