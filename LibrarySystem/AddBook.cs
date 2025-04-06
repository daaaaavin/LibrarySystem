using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class AddBook : Form
    {
        private Form1 mainForm;

        public AddBook(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private int GetID()
        {
            int nextId = mainForm.GetNextId();
            return nextId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtAuthor.Text) || string.IsNullOrEmpty(txtGenre.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Book newBook = new Book
            {
                Id = GetID(),  // Use the method from Form1 to get the next available ID
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Genre = txtGenre.Text.Trim(),
                DateAdded = DateTime.Now,
                PublicationDate = dtpPublished.Value,
                IsFavourite = checkFavourite.Checked,
                IsCheckedOut = false,
                DueDate = null,
                TimesRead = (int)nudTimesRead.Value

            };

            mainForm.books.Add(newBook); // Add the new book to the list in Form1
            mainForm.LoadBooks(); // Refresh the book list in Form1

            this.Close();
        }
    }
}
