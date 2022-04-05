using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {

        public bool LeatherSeats { get; set; }
        public int CupHolders { get; set; }
        public string Radio { get; set; }
        public int FloorMats { get; set; }

        public void Seats()
        {
            if (LeatherSeats == true)
            {
                Console.WriteLine($"I love leather seats!");

            }
            else
            {
                Console.WriteLine($"Cloth seats, yuck!");
            }


        }
    }
}
    /* Create 4 members that Car, Truck, & SUV all have in common. -DONE///
                 * Example: All vehicles have a number of wheels... for now..///
                 */


