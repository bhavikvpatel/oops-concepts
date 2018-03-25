using DemoConcepts.OtherDemo;
using System;

namespace DemoConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object Oriented Programming Concepts
            //Encapsulation();
            //Abstraction();
            //Inheritance();
            //CompileTimePolymorphism();
            //RunTimePolymorphism(); 
            #endregion

            #region Design Patterns
            Patterns.Factory();
            Patterns.Singleton(); 
            #endregion


            // NotifyService.CreateWatcherService();
            Console.ReadLine();
        }

        private static void Encapsulation()
        {
            Console.WriteLine("\n" + "Encapsulation Example:-");

            Encapsulation.Car car = new Encapsulation.Car();
            Console.WriteLine("Car mileage is : " + car.GetMileage()); //accessible outside "Car"
            Console.WriteLine("Car color is : " + car.GetColor()); //accessible outside "Car"

            //we can't call this method as it is inaccessible outside "Car"
            //car.GetEngineMakeFormula(); //commented because we can't access it

        }
        private static void Abstraction()
        {
            Console.WriteLine("\n" + "Abstraction Example:-");

            Abstraction.Car car = new Abstraction.Car();
            Console.WriteLine("Car mileage is : " + car.GetMileage()); //accessible outside "Car"
            Console.WriteLine("Car color is : " + car.GetColor()); //accessible outside "Car"

            //we can't call this method as it is inaccessible outside "Car"
            //car.GetEngineMakeFormula(); //commented because we can't access it
            Console.WriteLine("Car make formula is : " + car.DisplayMakeFormula()); //accessible outside

        }

        private static void Inheritance()
        {
            Console.WriteLine("\n" + "Inheritance Example:-");

            Inheritance.BMW car = new Inheritance.BMW();
            car.CC = 2000;
            car.color = "Black";
            car.SetModel("BMW M6 G-Power");   //model is private prop of base class, hence cannot be accessible directly
            car.SetSpeed(400);                //speed is private prop of base class, hence cannot be accessible directly
            car.gears = 6;

            Console.WriteLine("Car CC is: " + car.CC);
            Console.WriteLine("Color of car is: " + car.color);
            Console.WriteLine("Model of car is: " + car.GetModel());
            Console.WriteLine("Speed of car is: " + car.GetSpeed());
            Console.WriteLine("no of gears in car are: " + car.gears);
        }

        private static void CompileTimePolymorphism()
        {
            Console.WriteLine("\n" + "Compile time Polymorphism Example-1(StudentDetail) :-");
            Polymorphism.StudentDetail studentDetail = new Polymorphism.StudentDetail();
            studentDetail.Display("Bhavik");
            studentDetail.Display(26, 80.0f);

            Console.WriteLine("\n" + "Compile time Polymorphism Example-2(Shape) :-");

            Polymorphism.Shape shape = new Polymorphism.Shape();
            shape.Area(2.0f);
            shape.Area(20.0f, 30.0f);
            shape.Area(2.0f, 3.0f, 4.0f);
        }
        private static void RunTimePolymorphism()
        {
            Console.WriteLine("\n" + "Runtime Polymorphism :-");

            // calling the overriden method
            Polymorphism.DerivedClass derivedClass = new Polymorphism.DerivedClass();
            derivedClass.Display();

            Console.WriteLine("\n");
            // calling the baesd class method
            Polymorphism.BaseClass baseClass = new Polymorphism.BaseClass();
            baseClass.Display();
        }
    }
}
