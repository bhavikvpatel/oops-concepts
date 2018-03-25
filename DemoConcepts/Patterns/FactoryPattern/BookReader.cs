using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts
{
    public abstract class BookReader
    {
        //Base Class
        public BookReader()
        {
            //Constructor
            Book = BuyBook();
        }
        public Book Book { get; set; }

        //Abstract Factory Method BuyBook() which returns objects 
        public abstract Book BuyBook();

        public void DisplayOwnedBooks()
        {
            Console.WriteLine(Book.GetType().ToString());
        }


        // Method using generics to return specific object
        public Book BuyBook<T>()
        where T : Book, new()
        {
            return new T();
        }
    }

    public class HorrorBookReader : BookReader
    {
        //Derived Class
        // Abstract Method + Method Overriding (Runtime polymorphism)
        public override Book BuyBook()
        {
            return new Dracula();
        }
    }

    public class FantasyBookReader : BookReader
    {
        //Derived Class
        // Abstract Method + Method Overriding (Runtime polymorphism)
        public override Book BuyBook()
        {
            return new LordOfTheRings();
        }
    }

    public class AdventureBookReader : BookReader
    {
        //Derived Class
        // Abstract Method + Method Overriding (Runtime polymorphism)
        public override Book BuyBook()
        {
            return new TreasureIsland();
        }
    }

   
}
