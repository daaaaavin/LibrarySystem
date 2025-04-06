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
    public partial class FormViewEdit : Form
    {
        public Book book { get; set; }
        bool editMode;
        public FormViewEdit(Book selectedBook)
        {
            InitializeComponent();
            book = selectedBook;
            DisplayDetails();
            editMode = false;
        }

        private void DisplayDetails()
        {
            lblTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtPublished.Text = book.PublicationDate?.ToString("d") ?? "N/A";
            txtGenre.Text = book.Genre;
            txtDateAdded.Text = book.DateAdded.ToString("d");
            txtStatus.Text = book.IsCheckedOut ? "Checked Out" : "Available";
            txtReturn.Text = book.IsCheckedOut ? book.DueDate?.ToString("d") ?? "N/A" : "N/A";
            checkFavourite.Checked = book.IsFavourite;
            nudTimesRead.Value = book.TimesRead;
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                btnEditDetails.Text = "Save Changes";
                txtAuthor.ReadOnly = false;
                txtDateAdded.ReadOnly = false;
                txtGenre.ReadOnly = false;
                txtPublished.ReadOnly = false;
                checkFavourite.Enabled = true;
                nudTimesRead.Enabled = true;

            }
            else
            {
                btnEditDetails.Text = "Edit Details";
                txtAuthor.ReadOnly = true;
                txtDateAdded.ReadOnly = true;
                txtGenre.ReadOnly = true;
                txtPublished.ReadOnly = true;
                txtStatus.ReadOnly = true;
                txtReturn.ReadOnly = true;
                checkFavourite.Enabled = false;
                nudTimesRead.Enabled = false;
                // Save changes to the book object
                book.Author = txtAuthor.Text;
                book.PublicationDate = DateTime.TryParse(txtPublished.Text, out DateTime pubDate) ? pubDate : (DateTime?)null;
                book.Genre = txtGenre.Text;
                book.DateAdded = DateTime.TryParse(txtDateAdded.Text, out DateTime dateAdded) ? dateAdded : DateTime.Now;
                book.IsCheckedOut = txtStatus.Text == "Checked Out";
                book.DueDate = DateTime.TryParse(txtReturn.Text, out DateTime dueDate) ? dueDate : (DateTime?)null;
                book.IsFavourite = checkFavourite.Checked;
                book.TimesRead = (int)nudTimesRead.Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            book.Author = txtAuthor.Text;
            book.PublicationDate = DateTime.TryParse(txtPublished.Text, out DateTime pubDate) ? pubDate : (DateTime?)null;
            book.Genre = txtGenre.Text;
            book.DateAdded = DateTime.TryParse(txtDateAdded.Text, out DateTime dateAdded) ? dateAdded : DateTime.Now;
            book.IsCheckedOut = txtStatus.Text == "Checked Out";
            book.DueDate = DateTime.TryParse(txtReturn.Text, out DateTime dueDate) ? dueDate : (DateTime?)null;
            book.IsFavourite = checkFavourite.Checked;
            book.TimesRead = (int)nudTimesRead.Value;
            // Close the form and return DialogResult.OK

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
