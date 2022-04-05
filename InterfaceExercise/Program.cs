using System;
using System.Collections.Generic;


namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var car = new Car();     
            var truck = new Truck();
            var SUV = new SUV();

            car.Logo = "Mustang";
            car.TrunkSpace = "11 square feet";
            car.GasSaver = true;

            truck.Motto = "Like A Rock";
            truck.FourWheelDrive = true;
            truck.TrunkBedSize = 8;

            SUV.GasGuzzler = true;
            SUV.NumberOfSeat = 8;
            SUV.Radio = "Bose";



            //Console.WriteLine($"Free style riding in my {car.GasSaver} {car.Logo} and going shopping. I have a lot of room in my {car.TrunkSpace} trunk.");


            var vehicles = new List<IVehicle>() { car, truck, SUV };
            foreach (var vehicle in vehicles)
            {
                vehicle.LeatherSeats();
                vehicle.FloorMats();
                vehicle.Radio();

            }


            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany -DONE///

            //Create 3 classes called Car , Truck , & SUV -DONE///

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.-DONE///
                 * Example: All vehicles have a number of wheels... for now..///////
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company-DONE///
                 * regardless of vehicle type.//
                 *
                 *
                 * Example: public string Logo { get; set; }//////
                 */

            //In each of your car, truck, and suv classes//

                /*Create 2 members that are specific to each class///
                 * Example: truck has a bed size, while car has a trunk, while suv has a cargo hold size///
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.-DONE 
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }



    }
}
