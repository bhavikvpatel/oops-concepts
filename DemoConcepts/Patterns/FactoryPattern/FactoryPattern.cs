using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcepts
{
    /// <summary>
    /// Description:- Create instances of derived classes.
    /// Easy to implement and useful for centralizing object lifetime management and avoiding object creation code duplication
    /// </summary>
    public class FactoryPattern
    {
        public static void FactoryMethod()
        {
            var bookReaderList = new List<BookReader>();

            bookReaderList.Add(new AdventureBookReader());
            bookReaderList.Add(new FantasyBookReader());
            bookReaderList.Add(new HorrorBookReader());

            foreach (var reader in bookReaderList)
            {
                Console.WriteLine(reader.GetType().ToString());
                // language agnostic solution
                reader.DisplayOwnedBooks();

                Console.WriteLine();
            }

            // C# specific solution using generics
            var genericReader = new AdventureBookReader();
            Book book = genericReader.BuyBook<Encyclopedia>();
            Console.WriteLine(book.GetType().ToString());

            Console.ReadKey();
        }

    }
    /// <summary>
    /// Explaination:- 
    /// 
    ///     BookReader          --> Abstract creator class
    ///     BuyBook             --> Factory Method
    ///     HorrorBookReader    |
    ///     FantasyBookReader   |   --> These are the concrete creator classes which override abstract method and returning specific object
    ///     AdventureBookReader |
    /// 
    /// </summary>
}
