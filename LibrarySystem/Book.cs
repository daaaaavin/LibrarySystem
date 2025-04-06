using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibrarySystem
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? PublicationDate { get; set; }
        public bool IsFavourite { get; set; }

        //Goody Support (I don't user these parameters in my part of the code)
        public bool IsCheckedOut { get; set; }
        public DateTime? DueDate { get; set; }
        public int TimesRead { get; set; }

        public Book(int id, string title, string author, string genre, DateTime dateAdded, DateTime? publicationDate, bool isFavourite, bool isCheckedOut, DateTime? dueDate, int timesRead)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            DateAdded = dateAdded;
            PublicationDate = publicationDate;
            IsFavourite = isFavourite;
            IsCheckedOut = isCheckedOut;
            DueDate = dueDate;
            TimesRead = timesRead;
        }

        public Book() { }
    }
}
