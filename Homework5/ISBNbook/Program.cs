using System;
using System.Collections.Generic;
using ISBNbook.Models;

namespace ISBNbook
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initializing objects
            var catalogue = new Catalogue();

            var book1 = new Book("Harry Potter", DateTime.Now, new HashSet<string>() { "Joan K. Roaling", "Joanne Rowling", "FRSL" });
            var book2 = new Book("The Great Gatsby", DateTime.Now, new HashSet<string>() { "F. Scott Fitzgerald", "Francis Scott Key Fitzgerald" });
            var book3 = new Book("Anna Karenina", DateTime.Now, new HashSet<string>() { "Leo Tolstoy", "L. T." });
            var book4 = new Book("White Fang", DateTime.Now, new HashSet<string>() { "Jack London", "John Griffith London" });
            #endregion

            // XXX-X-XX-XXXXXX-X or XXXXXXXXXXXXX,

            #region Testing Add method
            catalogue.AddBook(book1, "123-4-56-789012-3");
            catalogue.AddBook(book2, "153-7-77-000444-0");
            catalogue.AddBook(book3, "1334447000123");
            catalogue.AddBook(book4, "1334447000123"); // Handling the case when ISBN number already exists
            #endregion

            #region Testing Find method
            Console.WriteLine(catalogue.FindBook("153-7-77-000444-0"));
            Console.WriteLine(catalogue.FindBook("1334447000123"));
            Console.WriteLine(catalogue.FindBook("123-4-56-789012-3"));

            //Console.WriteLine(catalogue.FindBook("1114447111111")); // exception case
            #endregion
        }
    }
}
