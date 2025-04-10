using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class stats : Form
    {
        Book selectedBook;
        public stats()
        {
            InitializeComponent();
        }

        public stats(Book selectedBook)
        {
            this.selectedBook = selectedBook;
            InitializeComponent();
          
            PopulateListView();
            lstStats.SelectedIndexChanged += lstStats_SelectedIndexChanged; // Ensure the event is wired up
        }

        private void lstStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook.RentalCount++;
          
        }
        private void PopulateListView()
        {
            if (selectedBook == null) return;

            lstStats.Items.Clear();

            // Create a ListViewItem for the book
            ListViewItem item = new ListViewItem(selectedBook.Title); // First column
            item.SubItems.Add(selectedBook.Author);                  // Second column
            item.SubItems.Add(selectedBook.Genre);                   // Third column
            item.SubItems.Add(selectedBook.DueDate > DateTime.Now ? "Rented" : "Overdue"); // Fourth column
            if (selectedBook.RentalCount > 0)
            {
                item.SubItems.Add("Due: " + selectedBook.DueDate.ToString()); // Add due date to the list view
            }
            else
                item.SubItems.Add("Not Rented Again");

            // Add the item to the ListView
            lstStats.Items.Add(item);
        }
    }
}
