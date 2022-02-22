using System;
using System.Collections.Generic;

namespace ISBNbook.Models
{
    public class Book
    {
        string Title;
        DateTime? PublicationDate;
        List<string> Authors;


        public Book(string title, DateTime? publicationDate, params string[] authors)
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
            Authors = new List<string>();
            Authors.AddRange(authors);
        }

        public override string ToString()
        {
            return $"Book title - {Title}, Publication date - {PublicationDate}, Main author - {Authors[0]}";
        }
    }
}
