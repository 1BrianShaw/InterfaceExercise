using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool HasThirdRow { get; set; }
        public bool HasFWD { get; set; }
        public int NumberOfWheels { get ; set ; }
        public bool HasHeadLights { get ; set ; }
        public bool HasTailLights { get ; set ; }
        public string Logo { get ; set ; }
        public string Slogan { get ; set ; }

        public void HonkNoise()
        {
            Console.WriteLine("My SUV goes boop boop");
        }
        public void PrintVehicleDetails()
        {
            Console.WriteLine($"Has 3rd row: {HasThirdRow}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Slogan: {Slogan}");
        }


    }
}
