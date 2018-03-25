
namespace DemoConcepts
{
    public static class Patterns
    {
        /// <summary>
        /// Design Patterns:-
        /// 
        /// Design patterns are solutions to software design problems you find again and again in real-world application development. 
        /// Patterns are about reusable designs and interactions of objects.
        /// 
        /// The 23 Gang of Four (GoF) patterns are generally considered the foundation for all other patterns. 
        /// They are categorized in three groups: Creational, Structural and Behavioral.
        /// 
        /// CREATIONAL PATTERNS:-
        ///    1) Abstract Factory --> Creates an instance of several families of classes
        ///    2) Factory Method   --> Creates an instance of several derived classes
        ///    3) Singleton        --> A class of which only a single instance can exist
        ///    4) Prototype        --> A fully initialized instance to be copied or cloned
        ///    5) Builder          --> Separates object construction from its representation
        /// 
        /// STRUCTURAL PATTERNS:-
        ///     
        /// 
        /// BEHAVIORAL PATTERNS:-
        ///     
        /// 
        /// </summary>
        public static void Factory()
        {
            //Example of 1) Abstract Factory and 2) Factory Method
            FactoryPattern.FactoryMethod();
        }
        public static void Singleton()
        {
            //Two Example of 3) Singleton
            SingletonPattern.ConfigurationExample();
            SingletonPattern.BusinessRuleExample();
        }
    }
}
