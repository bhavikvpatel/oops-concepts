using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts.Models
{
    /// <summary>
    /// Class:- 
    /// Collection of objects. 
    /// A class is a blueprint of an object that contains variables for storing data and functions to perform operations on the data. 
    /// (Logical representation of Data)
    /// </summary>
    public class Car
    {
        //Properties of Class Car
        public string color;
        public string engine;
        public int mileage;

        //Object's Behavior/Methods of class Car
        public string GetColor()
        {
            return "Red";
        }
        public int GetMileage()
        {
            return 20;
        }
    }

    class ObjectDemo
    {
        /// <summary>
        /// Object:- 
        /// Object is an instance of a class. 
        /// Objects are run-time entities of object oriented systems. 
        /// It is a bundle of related variables and methods.
        /// </summary>
        ObjectDemo()
        {
            //Instance of a Car Class
            Car car = new Car();

            //Accessing Car class Methods
            car.GetColor();
            car.GetMileage();
        }
    }
}
