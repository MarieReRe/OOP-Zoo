using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;



namespace MarieZoo.Mammals
{
    /// <summary>
    /// Summary description for ScarletIbis
    /// </summary>
    public abstract class Mammals : Animals, IFeed, ISound 

    {
        public abstract int GetAge();

        public abstract int GetWeight();


        /*  ----------------------  HOW DO WE USE CONSTRUCTOR??
        public Mammals(int weight, int age)
        {
            SetWeight(weight);
        GetAge(age);
        IsInZoo = true;

        }
 
    */

    public string FeedMe()
        {
            Console.WriteLine("Insert a quarter to feed the animals");
            string feedingTime = "Insert a quarter to feed the animals";
            return feedingTime;
        }

        public string GetMakeSound()
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