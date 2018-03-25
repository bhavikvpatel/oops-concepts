using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts.Inheritance
{
    /// <summary>
    /// Inheritance:-
    /// Inheritance enables you to create a new class that reuses, extends, and modifies the behavior that is defined in another class. 
    ///The class whose members are inherited is called the base class, and the class that inherits those members is called the derived class.
    /// Note: C# doesn't support multiple inheritance, i.e. you can specify only one base class for a derived class. 
    /// We can implement multiple inheritance in C# using interface. 
    /// </summary>
    public class Car
    {
        //It's base class 
        public string color;
        private int speed;
        private string model;
        public string GetModel()
        {
            return model;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void SetModel(string _model)
        {
            model = _model;
        }
        public void SetSpeed(int i)
        {
            speed = i;
        }
    }

    public class BMW : Car
    {
        //It's derived class which inherites base class "Car"
        public int CC;
        public int gears;
    }
    //public class Mercedes : Car
    //{
    //    //It's derived class which inherites base class "Car"
    //    public int CC;
    //    public int gears;
    //}
}
