using System;

namespace MarieZoo
{



	// derived : base
	public abstract class Bird : Animal
	{
		// public abstract added, wasn't sure if I had enough
		public abstract string Size { get; set; }

		// virtual method
		public virtual string Fly()
		{
			return "We have three special birds that are excited to meet you! We will have more coming soon!"; 
		}
	}
}
