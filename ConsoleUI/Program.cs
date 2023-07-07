using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle--DONE!
             * The vehicle class shall have three string properties Year, Make, and Model--DONE!
             * Set the defaults to something generic in the Vehicle class --DONE!
             * Vehicle shall have an abstract method called DriveAbstract with no implementation--DONE!
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.--DONE!
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle -- DONE!
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle -- DONE!
             * Provide the implementations for the abstract methods--DONE!
             * Only in the Motorcycle class will you override the virtual drive method--DONE!
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car car1 = new Car()
            {
                HasTrunk = true,
                Year = 2009,
                Make = "Honda",
                Model = "Civic",
            };

            Motorcyle motorcyle1 = new Motorcyle()
            {
                HasSideCart = true,
                Year = 1979,
                Make = "Harley-Davidson",
                Model = "H-D Sportster",
            };
            Vehicle car2 = new Car()
            {
                HasTrunk = true,
                Year = 1993,
                Make = "Ford",
                Model = "Explorer",
            };
            Vehicle motorcyle2 = new Motorcyle()
            {
                HasSideCart = false,
                Year = 1923,
                Make = "BMW",
                Model = "R32"

            };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcyle1);
            vehicles.Add(motorcyle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year:{vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion
        }
    }
}
