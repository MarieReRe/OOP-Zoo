using System;


namespace MarieZoo
{


	/// <summary>
	/// Summary description for ScarletIbis
	/// </summary>
	public  abstract class Animals
	{

		public virtual bool IsInZoo { get; set; }

		public virtual string Eat()
		{
			Console.WriteLine("Animals eat a lot!");
		}

	

	}
}
