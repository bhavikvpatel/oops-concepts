using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts.Polymorphism
{
    /// <summary>
    /// Polymorphism:-
    /// Polymorphism means one name, many forms. One function behaves in different forms.
    /// It has the ability for classes to provide different implementations of methods that are called through the same name.
    /// Compile time polymorphism - 
    /// Compile time polymorphism is method and operators overloading.It is also called early binding. In method overloading method performs the different task at the different input parameters.
    /// Runtime polymorphism -
    /// Runtime polymorphism is done using inheritance and virtual functions.Method overriding is called runtime polymorphism.It is also called late binding.
    /// </summary>
    public class StudentDetail
    {
        // Compile time polymorphism (METHOD OVERLOADING)
        //Example-1 :- 
        public void Display(string name)
        {
            Console.WriteLine("Your name is : " + name);
        }
        public void Display(int age, float marks)
        {
            Console.WriteLine("Your age is : " + age);
            Console.WriteLine("Your marks are :" + marks);
        }
    }
    public class Shape
    {
        // Compile time polymorphism (METHOD OVERLOADING)
        //Example-2 :- 
        public void Area(float r)
        {
            float a = (float)3.14 * r;
            // here we have used function overload with 1 parameter.
            Console.WriteLine("Area of a circle: {0}", a);
        }
        public void Area(float l, float b)
        {
            float x = (float)l * b;
            // here we have used function overload with 2 parameters.
            Console.WriteLine("Area of a rectangle: {0}", x);

        }
        public void Area(float a, float b, float c)
        {
            float s = (float)(a * b * c) / 2;
            // here we have used function overload with 3 parameters.
            Console.WriteLine("Area of a circle: {0}", s);
        }
    }

    /// <summary>
    /// Runtime Polymorphism
    /// </summary>
    public class BaseClass
    {
        // Runtime polymorphism (METHOD OVERRIDING)
        //Base Class
        public virtual void Display()
        {
            Console.Write("Method from Base Class called.");
        }
    }
    public class DerivedClass : BaseClass
    {
        // Runtime polymorphism (METHOD OVERRIDING)
        //Derived Class
        public override void Display()
        {
            Console.Write("Method from Derived Class called.");
        }
    }
}
