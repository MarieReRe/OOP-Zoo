using System;


namespace MarieZoo
{



	public abstract class Fish
	{
		public abstract decimal Length{ get; set; }
		public abstract string Color { get; set; }

		public  string Swim()
		{
			return "We do lots of swimming, swimming all day! Just keep swimming, just keep swimming....";
		}
	}
}
