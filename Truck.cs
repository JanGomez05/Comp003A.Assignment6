using System;
namespace Comp003A.Assignment6
{
    /// <summary>
    /// Trucks extends the Vehicle class
    /// </summary>
    internal class Truck : Vehicle
    {
        /***** fields section *****/
        private double _sizeOfTruckBed;


        /***** constructors section *****/
        /// <summary>
        /// Constructor that takes 4 parameters: truckBrand, truckModel,
        /// truckNumberOfWheels, and sizeOfTruckBed
        /// It reuses the base class (Vehicle)'s constructor that takes 3 parameters:
        /// brand, model, numberOfWheels
        /// </summary>
        /// <param name="truckBrand"></param>
        /// <param name="truckModel"></param>
        /// <param name="truckNumberOfWheels"></param>
        /// <param name="sizeOfTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels,
        double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            double SizeOfTruckBed = sizeOfTruckBed;
        }


        /***** properties section *****/
        public double SizeOfTruckbed
        {
            get { return _sizeOfTruckBed; }
            set { _sizeOfTruckBed = value; }
        }

        /***** methods section *****/
        /// <summary>
        /// Override the bade Vehicle's defintion for GetInfo()
        /// Calls the base Vehicle GetInfo() but adds on to it.
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"Im a {nameof(Truck)}.");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckbed} ft truck bed");

        }
    }
}

