using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }  
        public bool HasTailLights { get; set;}
        public void HonkNoise();

        public void PrintVehicleDetails();
    }
}
