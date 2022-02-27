using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ISBNbook.Models
{
    public class Catalogue
    {
        private Dictionary<string, Book> bookCollection = new Dictionary<string, Book>();


        public void AddBook(Book book, string isbn)
        {
            if (IsFormatCorrect(isbn) && bookCollection.ContainsKey(isbn))
            {
                bookCollection[isbn] = book;
            }
            else if (IsFormatCorrect(isbn))
            {
                bookCollection.Add(ToDefaultFormat(isbn), book);
            }
            else
            {
                throw new ArgumentException("ISBN isn't correct.");
            }
        }

        public Book FindBook(string isbn)
        {
            if (IsFormatCorrect(isbn))
            {
                if (bookCollection.Any(b => b.Key == ToDefaultFormat(isbn)))
                {
                    return bookCollection.First(b => b.Key == ToDefaultFormat(isbn)).Value;
                }
                else
                {
                    throw new ArgumentException("Such book hasn't found.");
                }
            }
            else
            {
                throw new ArgumentException("ISBN isn't correct.");
            }
        }

        private string ToDefaultFormat(string isbn) // default is an ISBN without '-'
        {
            return Regex.Replace(isbn, @"-", "");
        }

        private bool IsFormatCorrect(string isbn)
        {
            if (isbn.Length == 13 || isbn.Length == 17)
            {
                if (isbn.Contains('-'))
                {
                    if (Regex.IsMatch(isbn, @"\d{3}-\d-\d{2}-\d{6}-\d"))
                    {
                        return true;
                    }
                    return false;
                }
                else if (isbn.All(char.IsDigit))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
