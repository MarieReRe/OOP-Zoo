using System;
using System.Text;
using System.Collections.Generic;

namespace MarieZoo
{


	/// <summary>
	/// Summary description for ScarletIbis
	/// </summary>
	public  abstract class Animals
	{

		public virtual bool IsInZoo { get; set; }

        public abstract string Name();

        public abstract string Predator();

        public abstract string FunFact();
		public void DisplayCard()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Predator {Predator()}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Fun Fact: {FunFact()}");
            Console.WriteLine("----------------------------");

        }

	}
}
