using System;
using System.Collections.Generic;
using MarieZoo.Interfaces;


namespace MarieZoo.Birds
{
    public abstract class Bird: Animals
    {
        

        public abstract string ColorOfEggs();

        public abstract string NestingHabits();

        public bool YouCanFeedMe()
        {
            return true;
        }

    
    }
}
