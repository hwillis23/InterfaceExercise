using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string LeatherSeats { get ; set ; }
        public string CupHolder { get ; set ; }
        public string Radio { get ; set ; }
        public string FloorMats { get ; set ; }
        public string Logo { get ; set ; }
        public string Motto { get ; set ; }

        public bool GasGuzzler { get ; set ; }
        public int NumberOfSeat { get ; set ; }

        public void Guzzler()
        {
            if ( GasGuzzler == true )
            {
                Console.WriteLine($"driving this tank is too expensive");

            }
            else
            {

                Console.WriteLine($"we are good to roll");
            }


        }

    }
}
