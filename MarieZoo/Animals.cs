using System;
using System.Text;
using System.Collections.Generic;
using MarieZoo.Interfaces;

namespace MarieZoo
{
    public  abstract class Animals
	{

		public virtual bool IsInZoo { get; set; }

        public virtual string Name { get; set; }

        protected virtual void AdditionalDisplay(){}

        public abstract string Predator();

        public abstract string FunFact();
		public void DisplayCard()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{Name}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Our Predator(s): {Predator()}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Fun Fact: {FunFact()}");
            Console.WriteLine("----------------------------");


            if (this is IFeed feedMe)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Feed me: {feedMe.FeedMe}");
                Console.WriteLine("----------------------------");
            }
        }

	}
}
