using ISBNbook.Models;
using System;

namespace ISBNbook
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initializing objects
            var catalogue = new Catalogue();

            var book1 = new Book("Harry Potter", DateTime.Now, "Joan K. Roaling");
            var book2 = new Book("The Great Gatsby", DateTime.Now, "F. Scott Fitzgerald");
            var book3 = new Book("Anna Karenina", DateTime.Now, "Leo Tolstoy");
            #endregion

            // XXX-X-XX-XXXXXX-X or XXXXXXXXXXXXX,

            #region Testing Add method
            catalogue.AddBook(book1, "123-4-56-789012-3");
            catalogue.AddBook(book2, "153-7-77-000444-0");
            catalogue.AddBook(book3, "1334447000123");
            #endregion

            #region Testing Find method
            Console.WriteLine(catalogue.FindBook("153-7-77-000444-0"));
            Console.WriteLine(catalogue.FindBook("1334447000123"));
            Console.WriteLine(catalogue.FindBook("123-4-56-789012-3"));

            Console.WriteLine(catalogue.FindBook("1114447111111")); // exception case
            #endregion
        }
    }
}
