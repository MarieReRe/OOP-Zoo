using MarieZoo.Mammals;
using System;



namespace MarieZoo.Mammals
{
    /// <summary>
    /// Summary description for ScarletIbis
    /// </summary>
    public abstract class Mammals : Animals, IFeed, ISound 

    {
        public abstract int Age { get; set; }
        public abstract int Weight { get; set; }

        public Mammals(int weight, int age)
        {
            Weight = weight;
            Age = age;
            IsInZoo = true;

        }
        public string FeedMe()
        {
            Console.WriteLine("Insert a quarter to feed the animals");
            string feedingTime = "Insert a quarter to feed the animals";
            return feedingTime;
        }

        public string MakeSound()
        {
            Console.WriteLine("All of our mammals make their own unique sound");
            string uniqueSound = "All of our mammals make their own unique sound";
            return uniqueSound;
        }

        public string Hunting()
        {
            Console.WriteLine("Our animlals hunt in various ways");
            string huntingMethod = "Our animlals hunt in various ways";
            return huntingMethod;
        }
        


    }

}