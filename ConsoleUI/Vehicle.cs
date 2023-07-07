using System;
namespace ConsoleUI
{
	internal abstract class Vehicle
	{
		public int Year { get; set; } = 0;
		public string Make { get; set; } = "Defualt";
		public string Model { get; set; } = "Default";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine("This is the base implementation");
		}
	}
}

