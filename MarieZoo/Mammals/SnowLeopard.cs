using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace MarieZoo.Mammals
{
    public class SnowLeopard : Mammals, IDesign, ISound
    {
        public override string Name { get; set; }
        public override string Predator()
        {
            return "Expansion of human settlement, especially livestock grazing has led to increased conflict.";
        }

        public override string FunFact()
        {
            return "Snow leopards are the only big cat that cannot roar";
        }

        public decimal LengthInInches => 63;

        public string Color => "Creamy yellow with grey or black";

        public string LegsOrFins => "I have four legs";

        public string Movement => "Running, walking, pouncing";

        public override int GetAge()
        {
            return 3;
        }

        public override int GetWeight()
        {
            return 200;
        }

        public new string GetMakeSound()
        {
            return "Meow meow, purr purr";
        }
    }
}
