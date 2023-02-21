using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasBed { get; set; }    
        public bool HasHitch { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool HasHeadLights { get ; set ; }
        public bool HasTailLights { get ; set ; }
        public string Logo { get ; set ; }
        public string Slogan { get ; set ; }

        public void HonkNoise()
        {
            Console.WriteLine("My Truck goes ayuuuga");
        }
        public void PrintVehicleDetails()
        {
            Console.WriteLine($"Has Bed: {HasBed}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Slogan: {Slogan}");
        }

    }
}
