using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool LeatherSeats { get ; set ; }
        public int CupHolders { get ; set ; }
        public string Radio { get ; set ; }
        public int FloorMats { get ; set ; }
        public string Logo { get ; set ; }
        public string Motto { get ; set ; }

        public bool FourWheelDrive { get ; set ; }
        public int TrunkBedSize { get; set; } 

        public void Drive()
        {
            if ( FourWheelDrive == true )
            {
                Console.WriteLine($"rolling on all fours");

            }
            else
            {
                Console.WriteLine($"will get stuck in the mud");

            }

        }



    }
}
