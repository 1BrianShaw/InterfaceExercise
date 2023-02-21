using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool FoldingBackSeats { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool HasHeadLights { get ; set ; }
        public bool HasTailLights { get ; set ; }
        public string Logo { get; set; }
        public string Slogan { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("My Car goes Honk Honk");
        }
        public void PrintVehicleDetails()
        {
            Console.WriteLine($"Has trunk: {HasTrunk}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Slogan: {Slogan}");
        }
    }
}
