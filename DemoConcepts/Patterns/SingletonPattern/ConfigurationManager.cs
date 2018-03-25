using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts
{
    /// <summary>
    /// Singleton Example 1:-
    ///     Efficient approach which provides thread safety.  
    ///     To achieve this behavior a lock strategy is used to assure that only a single thread is allowed to do the null check and create a new instance if it does not already exist.
    /// </summary>

    public sealed class ConfigurationManager
    {
                
        private static ConfigurationManager instance;
        private static object syncRoot = new Object();

        private ConfigurationManager()
        {

        }
        public static ConfigurationManager GetInstance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }

                return instance;
            }
        }
        public void DisplayConfiguration()
        {
            Console.WriteLine("Single instance object");
        }
    }
    /// <summary> 
    /// Explaination:-
    /// In example, the default constructor is defined as private so that it is not possible to instantiate the object from the outside. 
    ///             The class is also marked as sealed which means that inheritance is not allowed for it.
    ///             The internally instantiated object is stored in a private variable that is marked as static.
    ///             
    ///             The default constructor is defined as private so that it is not possible to instantiate the object from the outside.
    ///             
    ///             The public static property GetInstance is used to allow access to this object. 
    ///             It contains the business logic that assures that only a single instance can ever exist.
    /// </summary>
}
