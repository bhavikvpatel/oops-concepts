using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts.Abstraction
{
    /// <summary>
    /// Abstraction:-
    /// Abstraction is a process of hiding the implementation details and displaying the essential features.
    /// Abstractions are usually implemented as abstract classes or interfaces.
    /// </summary>
    public class Car
    {
        public int mileage = 20;
        public string color = "Blue";
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

        //Its public – so accessible outside class
        public string DisplayMakeFormula()
        {
            //"GetEngineMakeFormula()" is private but accessible and limited to this class only
            return GetEngineMakeFormula();
        }
    }
}
