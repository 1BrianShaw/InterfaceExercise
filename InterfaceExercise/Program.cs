using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany -D

            //Create 3 classes called Car , Truck , & SUV-D

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car1= new Car() {HasTrunk = true, FoldingBackSeats = true, NumberOfWheels = 4, HasHeadLights = true, HasTailLights = true, Slogan = "BMW - The Ultimate Driving Machine"};
            Truck truck1 = new Truck() { HasBed = true, HasHitch = false, NumberOfWheels = 4, HasHeadLights = true, HasTailLights = true, Slogan = "Chevy - Like a Rock" };
            SUV suv1 = new SUV() { HasFWD = true, HasThirdRow = true, NumberOfWheels = 4, HasHeadLights = true, HasTailLights = true, Slogan = "Mercedes - Unlike any other" };

            List<IVehicle> vehicles = new List<IVehicle>() { truck1, suv1, car1 };

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine("======================");
                vehicle.PrintVehicleDetails();
                vehicle.HonkNoise();
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
