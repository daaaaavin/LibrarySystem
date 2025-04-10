using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public List<Book> books = new List<Book>();
        private List<Book> favouritedBooks = new List<Book>();
        public List<Book> rentedBooks = new List<Book>();
        public Form1()
        {
            books = GenerateSampleList();
            InitializeComponent();
            InitializeGridView();
            InitializeFavouritesGrid();
            LoadBooks();
            PopulateFavourites();
            PopulateRentedBooks();
        }



        private List<Book> LoadFromFile()
        {
            List<Book> loadedBooks = new List<Book>();

            string[] lines = File.ReadAllLines("BookList.dat");
            foreach (var line in lines.Skip(1))
            {
                var variables = line.Split(',');

                int id = int.Parse(variables[0]);
                string title = variables[1];
                string author = variables[2];
                string genre = variables[3];
                DateTime dateAdded = DateTime.Parse(variables[4]);
                DateTime? publicationDate = string.IsNullOrEmpty(variables[5]) ? (DateTime?)null : DateTime.Parse(variables[5]);
                bool isCheckedOut = bool.Parse(variables[6]);
                bool isFavourite = bool.Parse(variables[7]);
                DateTime? dueDate = string.IsNullOrEmpty(variables[8]) ? (DateTime?)null : (DateTime.TryParse(variables[8], out DateTime tempDueDate) ? tempDueDate : (DateTime?)null);
                int timesRead = int.Parse(variables[9]);

                loadedBooks.Add(new Book(id, title, author, genre, dateAdded, publicationDate, isFavourite, isCheckedOut, dueDate, timesRead, 0));
            }

            return loadedBooks;
        }

        private void ExportToFile(List<Book> book)
        {
            var lines = new List<string>
            {
                "Id,Title,Author,Genre,DateAdded,PublicationDate,IsCheckedOut,IsFavourite,DueDate,TimesRead"
            };

            foreach (var b in books)
            {
                var line = $"{b.Id},{b.Title},{b.Author},{b.Genre},{b.DateAdded},{b.PublicationDate},{b.IsCheckedOut},{b.IsFavourite},{b.DueDate},{b.TimesRead}";
                lines.Add(line);
            }

            File.WriteAllLines("BookList.dat", lines);

        }


        private void InitializeGridView()
        {
            dgvBookView.AutoGenerateColumns = false;
            dgvBookView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookView.MultiSelect = false;
            dgvBookView.ReadOnly = false;

            //Columns
            dgvBookView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Name = "Id", Width = 50 });
            dgvBookView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Title", Width = 200 });
            dgvBookView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Author", HeaderText = "Author", Width = 150 });
            dgvBookView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Genre", HeaderText = "Genre", Width = 100 });


            //Delete Button
            DataGridViewButtonColumn btnDeleteBook = new DataGridViewButtonColumn();
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.HeaderText = "";
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseColumnTextForButtonValue = true;
            dgvBookView.Columns.Add(btnDeleteBook);

            //View/Edit Button
            DataGridViewButtonColumn btnViewEditBook = new DataGridViewButtonColumn();
            btnViewEditBook.Name = "btnViewEditBook";
            btnViewEditBook.HeaderText = "";
            btnViewEditBook.Text = "View/Edit";
            btnViewEditBook.UseColumnTextForButtonValue = true;
            dgvBookView.Columns.Add(btnViewEditBook);

            dgvBookView.CellClick += DgvBookView_CellClick;
        }

        private void InitializeFavouritesGrid()
        {
            dgvFavourites.AutoGenerateColumns = false;
            dgvFavourites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFavourites.MultiSelect = false;
            dgvFavourites.ReadOnly = true;
            //Columns
            dgvFavourites.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
            dgvFavourites.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Title", Width = 200 });
            dgvFavourites.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Author", HeaderText = "Author", Width = 150 });
            dgvFavourites.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Genre", HeaderText = "Genre", Width = 100 });
            dgvFavourites.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TimesRead", HeaderText = "Times Read", Width = 50 });

            DataGridViewButtonColumn btnUnfavourite = new DataGridViewButtonColumn();
            btnUnfavourite.Name = "btnUnfavourite";
            btnUnfavourite.HeaderText = "";
            btnUnfavourite.Text = "Remove From Favourites";
            btnUnfavourite.UseColumnTextForButtonValue = true;
            dgvFavourites.Columns.Add(btnUnfavourite);

            dgvFavourites.CellClick += DgvFavourites_CellClick;
        }



        //Initial Sample Data
        private List<Book> GenerateSampleList()
        {
            return new List<Book>
            {
                new Book(1, "Ready Player One", "Ernest Cline", "Science Fiction", DateTime.Now.AddDays(-10), new DateTime(2011, 8, 16), true, false, null, 3, 0),
                new Book(2, "The Outsiders", "S. E. Hinton", "Young Adult", DateTime.Now.AddDays(-20), new DateTime(1967, 4, 24), false, false, null, 2, 0),
                new Book(3, "The Maze Runner", "James Dashner", "Science Fiction", DateTime.Now.AddDays(-15), new DateTime(2009, 10, 6), true, false, null, 4 ,0),
                new Book(4, "Dune", "Frank Herbert", "Science Fiction", DateTime.Now.AddDays(-5), new DateTime(1965, 8, 1), true, false, null, 5 , 0),
                new Book(5, "Brave New World", "Aldous Huxley", "Dystopian", DateTime.Now.AddDays(-25), new DateTime(1932, 1, 1), false, false, null, 1, 0),
                new Book(6, "A Brief History of Time", "Stephen Hawking", "Non-Fiction", DateTime.Now.AddDays(-30), new DateTime(1988, 4, 1), true, false, null, 3, 0),
                new Book(7, "The Sailor Who Fell From Grace With The Sea", "Yukio Mishima", "Fiction", DateTime.Now.AddDays(-12), new DateTime(1963, 1, 1), false, false, null, 2, 0)
            };
        }

        //Refresh Book List
        public void LoadBooks()
        {

            dgvBookView.DataSource = null; //Incase grid view is already initialized
            dgvBookView.DataSource = books;
        }

        //Refresh Favourites List
        private void PopulateFavourites()
        {
            favouritedBooks.Clear();
            foreach (var book in books)
            {
                if (book.IsFavourite)
                {
                    favouritedBooks.Add(book);
                }
            }
            dgvFavourites.DataSource = null; //Incase grid view is already initialized
            dgvFavourites.DataSource = favouritedBooks;
        }

        private void PopulateRentedBooks()
        {
            rentedBooks.Clear();
            foreach (var book in books)
            {
                if (book.IsCheckedOut)
                {
                    rentedBooks.Add(book);
                }
            }
        }

        private void DgvBookView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvBookView.Columns[e.ColumnIndex].Name == "btnDeleteBook")
                {
                    DeleteBook(e.RowIndex);
                }
                else if (dgvBookView.Columns[e.ColumnIndex].Name == "btnViewEditBook")
                {
                    ViewEditBook(e.RowIndex);
                }
            }
        }



        private void DeleteBook(int rowIndex)
        {
            if (MessageBox.Show("Are you sure you want to delete this book?", "Delete Book", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var cell = dgvBookView.Rows[rowIndex].Cells["Id"];
                int bookId = (int)cell.Value;
                Book bookToRemove = books.FirstOrDefault(b => b.Id == bookId);
                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    LoadBooks();
                    PopulateFavourites();
                }

            }
        }

        private void ViewEditBook(int rowIndex)
        {
            var cell = dgvBookView.Rows[rowIndex].Cells["Id"];
            int bookId = (int)cell.Value;
            Book selectedBook = books.FirstOrDefault(b => b.Id == bookId);
            if (selectedBook != null)
            {
                using (FormViewEdit form = new FormViewEdit(selectedBook))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Update the book in the list
                        int index = books.FindIndex(b => b.Id == bookId);
                        if (index != -1)
                        {
                            books[index] = form.book;
                            LoadBooks();
                            PopulateFavourites();
                        }
                    }
                }
            }
        }


        //Unfavourite a book
        private void DgvFavourites_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvFavourites.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var cell = dgvFavourites.Rows[e.RowIndex].Cells["Id"];
                int bookId = (int)cell.Value;
                Book? selectedBook = favouritedBooks.FirstOrDefault(b => b.Id == bookId);
                if (selectedBook != null)
                {
                    if (MessageBox.Show("Are you sure you want to remove this book from favourites?", "Remove From Favourites", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        selectedBook.IsFavourite = false;
                        LoadBooks();
                        PopulateFavourites();
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            books = LoadFromFile();
            LoadBooks();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToFile(books);
            MessageBox.Show("Data Exported.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBar = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchBar))
            {
                MessageBox.Show("Search Bar Is Empty, Try Again.");
                return;
            }

            List<Book> results;

            if (btnSearch.Text == "Search")
            {
                if (rdoSearchByName.Checked)
                {
                    results = books.Where(b => b.Title != null && b.Title.ToLower().Contains(searchBar)).ToList();
                }
                else if (rdoSearchByAuthor.Checked)
                {
                    results = books.Where(b => b.Author != null && b.Author.ToLower().Contains(searchBar)).ToList();
                }
                else if (rdoSearchByGenre.Checked)
                {
                    results = books.Where(b => b.Genre != null && b.Genre.ToLower().Contains(searchBar)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a search filter (Title, Author, or Genre).");
                    return;
                }
                dgvBookView.DataSource = null;
                dgvBookView.DataSource = results;
            }
            else
            {
                btnSearch.Text = "Search";
                txtSearch.Text = "";

                //Reset the grid view to show all books
                dgvBookView.DataSource = null;
                dgvBookView.DataSource = books;
            }
        }

        private void SortBooks()
        {
            string? sortBy = cmbSort.SelectedItem?.ToString();

            if (sortBy == null)
            {
                MessageBox.Show("Please select a sort option.");
                return;
            }

            switch (sortBy)
            {
                case "Title":
                    books = books.OrderBy(b => b.Title).ToList();
                    break;
                case "Author":
                    books = books.OrderBy(b => b.Author).ToList();
                    break;
                case "Genre":
                    books = books.OrderBy(b => b.Genre).ToList();
                    break;
                case "Published":
                    books = books.OrderBy(b => b.PublicationDate).ToList();
                    break;
                case "Date Added":
                    books = books.OrderBy(b => b.DateAdded).ToList();
                    break;
                default:
                    books = books.OrderBy(b => b.Id).ToList();
                    break;
            }

            LoadBooks();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook(this);
            addBookForm.Show();

        }

        public int GetNextId()
        {
            return books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExportToFile(books);
        }

        private void btnYourBooks_Click(object sender, EventArgs e)
        {
            PopulateRentedBooks();
            YourBooks yourBooksForm = new YourBooks(books);
            yourBooksForm.Show();
        }
    }
}
