using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts.Encapsulation
{
    /// <summary>
    /// Encapsulation:-
    /// Wrapping up a data member and method together into a single unit (in other words class) is called Encapsulation. 
    /// Encapsulation is enclosing the related operations and data related to an object into that object.
    
    /// In Encapsulation, the data is not accessed directly; it is accessed through the functions present inside the class. 
    /// In simpler words, attributes of the class are kept private and public getter and setter methods are provided to manipulate these attributes. 
    /// Thus, encapsulation makes the concept of data hiding possible.
    /// </summary>
    public class Car
    {
        public int mileage = 20;
        public string color = "Black";
        private string formula = "a*b";
        //Its public – so accessible outside class
        public int GetMileage()
        {
            return mileage;
        }

        //Its public – so accessible outside class
        public string GetColor()
        {
            return color;
        }

        //Its private – so not accessible outside class
        private string GetEngineMakeFormula()
        {
            return formula;
        }
    }
}
