﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public string LeatherSeats { get ; set; }
        public string CupHolder { get; set; }
        public string Radio { get; set; }
        public string FloorMats { get; set ; }
        public string Logo { get ; set; }
        public string Motto { get ; set; }

        public string TrunkSpace { get; set; }
        public bool GasSaver { get; set; }

        public void Gas()
        {
            if (GasSaver == true)
            {
                Console.WriteLine($"gas saver");
      
            }
            else
            {
                Console.WriteLine($"this is going to hurt at the pump");
            }


        }


    }

    

    
}
