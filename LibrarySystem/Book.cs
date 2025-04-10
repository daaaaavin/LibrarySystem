using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibrarySystem
{
    //Davin's Code:
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? PublicationDate { get; set; }
        public bool IsFavourite { get; set; }

        //Goody's variables:
        public bool IsCheckedOut { get; set; }
        public DateTime? DueDate { get; set; }
        public int TimesRead { get; set; }

        public int RentalCount { get; set; } // New property to track rental count

        public Book(int id, string title, string author, string genre, DateTime dateAdded, DateTime? publicationDate, bool isFavourite, bool isCheckedOut, DateTime? dueDate, int timesRead, int rentalCount)
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
            RentalCount = rentalCount; // Initialize the new property
        }

        public Book() { }

        //Goody's Code:
        private string v1;
        private string v2;
        private string v3;
        public Book(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Book other) return false;
            return Title == other.Title && Author == other.Author && DueDate == other.DueDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Author, DueDate);
        }
    }
}
