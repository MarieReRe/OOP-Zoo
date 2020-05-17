using System;
using System.Text;
using System.Collections.Generic;

namespace MarieZoo
{
    public  abstract class Animals
	{

		public virtual bool IsInZoo { get; set; }

        public abstract string Name();

        public abstract string Predator();

        public abstract string FunFact();
		public void DisplayCard()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{Name()}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Our Predator(s): {Predator()}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Fun Fact: {FunFact()}");
            Console.WriteLine("----------------------------");

        }

	}
}
