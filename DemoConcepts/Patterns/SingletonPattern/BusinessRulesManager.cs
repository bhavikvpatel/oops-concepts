using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts
{
    /// <summary>
    /// Singleton Example 2:-
    ///     A default approach to be used for singleton implementations 
    ///     since there is no locking in it which makes it more efficient in terms of performance.  
    /// </summary>
    public sealed class BusinessRulesManager
    {
        private BusinessRulesManager()
        {

        }

        public static BusinessRulesManager GetInstance
        {
            get
            {
                return BusinessRulesManagerImpl.instance;
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Single instance object");
        }

        private class BusinessRulesManagerImpl
        {
            static BusinessRulesManagerImpl()
            {

            }
            internal static readonly BusinessRulesManager instance = new BusinessRulesManager();
        }
    }
    /// <summary> 
    /// Explaination:-
    /// In example, the default constructor is defined as private so that it is not possible to instantiate the object from the outside. 
    ///             The class is also marked as sealed which means that inheritance is not allowed for it.
    ///             The internally instantiated object is stored in a private variable that is marked as static.
    ///             
    ///             This time a private nested class is used to provide access to the instance that must only exist once in the application.
    ///             This nested class has a static default constructor and an internal static read-only instance of the object. 
    ///             Only the container class has access to the instance which will due to the software design (auto-instantiated and marked as read-only) only exist once.
    /// </summary>
}
