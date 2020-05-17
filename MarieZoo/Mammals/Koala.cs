using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Mammals

{
    public class Koala : Mammals, IDesign
    {
        public override string Name { get; set; }
        public override string Predator()
        {
            return "Humans and deforestation is my biggest threat";
        }

        public override string FunFact()
        {
            return
                " Although these beautiful creatures are protected by law, and not classed as an endangered species, their habitat is under threat. Sadly, around 80% of koala habitat has been lost to human homes, drought and bush fires.";
        }

        public decimal LengthInInches => 30;

        public string Color => throw new NotImplementedException();

        public string LegsOrFins => throw new NotImplementedException();

        public string Movement => throw new NotImplementedException();

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
