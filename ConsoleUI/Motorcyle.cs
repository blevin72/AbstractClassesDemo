using System;
namespace ConsoleUI
{
	internal class Motorcyle : Vehicle
	{
		public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcyle is driving.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcyle's virtual Drive Method");
        }
    }
}

