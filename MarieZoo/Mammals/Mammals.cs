using MarieZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;



namespace MarieZoo.Mammals
{
    /// <summary>
    /// Summary description for ScarletIbis
    /// </summary>
    public abstract class Mammals : Animals

    {
      

        public abstract int GetAge();

        public abstract int GetWeight();

   

    public bool YouCanFeedMe()
    {
        return true;
    }

    public string GetMakeSound()
        {
            Console.WriteLine("All of our mammals make their own unique sound");
            string uniqueSound = "All of our mammals make their own unique sound";
            return uniqueSound;
        }

       
        


    }

}