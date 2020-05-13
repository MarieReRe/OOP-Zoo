using MarieZoo.Birds;
using MarieZoo.Interfaces;
using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo
{
    public class Puffin : Bird, IDesign, ISound, IEnvironment, IFeed
    {
        public override string Name { get; set; }
        public decimal LengthInInches => 5;

        public string Color => "I am black and white with variants of orange on my beak";

        public string LegsOrFins => "I have two small orange feet";

        public string Movement => "I fly,swim, sometimes walk";

        public string Predators => "Humans hunt us for food";

        public string FunFact => "puffins cannot take off without a running start";

        public override string ColorOfEggs()
        {
           return "We lay white eggs, sometimes they have a tint of lilac";
        }

        public string FeedMe()
        {
            return "Please do not feed me, you'll spoil my appetite";
        }

        public string GetMakeSound()
        {
            return "chirp chirp";
        }

        public override string NestingHabits()
        {
            return "We nest on the cliffside in Iceland";
        }
    }
}
