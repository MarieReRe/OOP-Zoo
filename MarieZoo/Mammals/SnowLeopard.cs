using MarieZoo.Interfaces;
using MarieZoo.Mammals;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.Serialization;
using System.Text;

namespace MarieZoo.Mammals
{
    internal class SnowLeopard : Mammals, IDesign, IEnvironment, IFeed, ISound
    {
        public decimal LengthInInches => 63;

        public string Color => "Creamy yellow with grey or black";

        public string LegsOrFins => "I have four legs";

        public string Movement => "Running, walking, pouncing";

        public string Predators => "Expansion of human settlement, especially livestock grazing has led to increaded conflict.";

        public string FunFact => "Snow leopards are the only big cat that cannot roar";

        public override int GetAge()
        {
            return 3;
        }

        public override int GetWeight()
        {
            return 200;
        }

        public string GetMakeSound()
        {
            return "Meow meow, purr purr";
        }
    }
}
