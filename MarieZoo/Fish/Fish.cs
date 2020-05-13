using System;


namespace MarieZoo
{



	public abstract class Fish
	{
		public abstract int Length{ get; set; }
		public abstract int Color { get; set; }

		public override string Swim()
		{
			return "We do lots of swimming, swimming all day! Just keep swimming, just keep swimming....";
		}
	}
}
