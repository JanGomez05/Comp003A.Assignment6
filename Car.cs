using System;
namespace Comp003A.Assignment6
{
    /// <summary>
    /// Car extends the Vehicle Class
    /// </summary>
    internal class Car : Vehicle
    {

        /***** constructors section *****/
        // by default, a class has a default constructor that does not take any parameters
        // therfore, you do not have to explicity create one


        /***** methods section *****/
        /// <summary>
        /// Overide the base Vehicle's defintion for GetInfo()
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("I don't want to disclose my information");
       
        }
    }
}

