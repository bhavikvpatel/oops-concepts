using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts
{
    /// <summary>
    /// Abstract class defines the interface and class structure for all objects that get build by 
    /// specified concrete creators via their factory methods.
    /// </summary>
    public abstract class Book
    {
        //Base class

    }

    public class Dracula : Book
    {
        //Derived Class of Book
    }

    public class LordOfTheRings : Book
    {
        //Derived Class of Book
    }

    public class TreasureIsland : Book
    {
        //Derived Class of Book
    }

    public class Encyclopedia : Book
    {
        //Derived Class of Book
    }
}
