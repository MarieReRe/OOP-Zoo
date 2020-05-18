using System;
using MarieZoo.Interfaces;
using System.Collections.Generic;


namespace MarieZoo.Fish
{



	public abstract class Fish: Animals
	{
        
		public abstract int GetNumberOfTeeth();

		public abstract string GetDiet();

		public  string Swim()
		{
			return "We do lots of swimming, swimming all day! Just keep swimming, just keep swimming.What do we do we swim,swim....";
		}

		public bool YouCanFeedMe()
		{
			return true;
		}

		
	}
}
