using System;
using System.Collections.Generic;
using System.Text;

namespace ISBNbook.Models
{
    public class Book
    {
        private string Title { get; }
        private DateTime? PublicationDate { get; }
        private HashSet<string> Authors { get; }


        public Book(string title, DateTime? publicationDate, HashSet<string> authors)
        {
            if (!String.IsNullOrEmpty(title))
            {
                Title = title;
            }
            else
            {
                throw new ArgumentNullException("Title coldn't be null or empty.");
            }
            PublicationDate = publicationDate;
            Authors = authors;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder($"Book title - {Title}, Publication date - {PublicationDate.Value.ToShortDateString()}, Authors - ");

            foreach (var item in Authors)
            {
                result.Append(item + "; ");
            }
            return result.ToString();
        }
    }
}
