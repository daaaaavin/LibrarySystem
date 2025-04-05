using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        public int ID { get; set; } // Unique identifier for each book
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DatePublished { get; set; }
        public bool IsFavourite { get; set; }
        
        
        
        //Goody features (I don't use these parameters during my coding
        public bool IsCheckedOut { get; set; }

        public DateTime? DueDate { get; set; } // Nullable DateTime for due date

        public int TimesRead { get; set; } //Number of times book has been read

        public Book(int id, string title, string author, string genre, DateTime dateAdded, DateTime datePublished, bool isFavourite, bool isCheckedOut)
        {
            ID = id; 
            Title = title; 
            Author = author; 
            Genre = genre;
            DateAdded = dateAdded;
            DatePublished = datePublished;

            IsFavourite = false; // Initialize favourite status to false
            IsCheckedOut = false; //Initialize checked out status to false
            DueDate = null; // Initialize due date to null
            TimesRead = 0; // Initialize times read to 0
        }
    }   
}
