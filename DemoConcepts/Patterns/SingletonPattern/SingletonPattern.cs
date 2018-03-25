using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts
{
    /// <summary>
    /// Singleton Pattern:-
    /// Class with only one single possible instance
    /// Often used for objects that need to provide global access with the constraint of only one single instance in the application
    /// </summary>
    public class SingletonPattern
    {
        public static void ConfigurationExample()
        {
            var configurationManager = ConfigurationManager.GetInstance;
            configurationManager.DisplayConfiguration();

            //Console.ReadKey();
        }
        public static void BusinessRuleExample()
        {
            var businessRulesManager = BusinessRulesManager.GetInstance;
            businessRulesManager.DisplayRules();

            //Console.ReadKey();
        }
    }
}
