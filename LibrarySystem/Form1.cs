namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            books = GenerateSampleList();
            InitializeComponent();
            InitializeGridView();
            LoadBooks();
        }

        private void InitializeGridView()
        {
            dgvBookView.AutoGenerateColumns = false;
            dgvBookView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookView.MultiSelect = false;
            dgvBookView.ReadOnly = false;

            //Columns
            dgvBookView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
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

        private List<Book> GenerateSampleList()
        {
            return new List<Book>
            {
                new Book(1, "Ready Player One", "Ernest Cline", "Science Fiction", DateTime.Now.AddDays(-10), new DateTime(2011, 8, 16), true, false, null, 3),
                new Book(2, "The Outsiders", "S. E. Hinton", "Young Adult", DateTime.Now.AddDays(-20), new DateTime(1967, 4, 24), false, false, null, 2),
                new Book(3, "The Maze Runner", "James Dashner", "Science Fiction", DateTime.Now.AddDays(-15), new DateTime(2009, 10, 6), true, false, null, 4),
                new Book(4, "Dune", "Frank Herbert", "Science Fiction", DateTime.Now.AddDays(-5), new DateTime(1965, 8, 1), true, false, null, 5),
                new Book(5, "Brave New World", "Aldous Huxley", "Dystopian", DateTime.Now.AddDays(-25), new DateTime(1932, 1, 1), false, false, null, 1),
                new Book(6, "A Brief History of Time", "Stephen Hawking", "Non-Fiction", DateTime.Now.AddDays(-30), new DateTime(1988, 4, 1), true, false, null, 3),
                new Book(7, "The Sailor Who Fell From Grace With The Sea", "Yukio Mishima", "Fiction", DateTime.Now.AddDays(-12), new DateTime(1963, 1, 1), false, false, null, 2)
            };
        }

        private void LoadBooks()
        {

            dgvBookView.DataSource = null; //Incase grid view is already initialized
            dgvBookView.DataSource = books;
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
                books.RemoveAt(rowIndex);
                LoadBooks();
            }
        }

        private void ViewEditBook(int rowIndex)
        {
            //undone
            Book selectedBook = books[rowIndex];
            if (selectedBook != null)
            {
                using (FormViewEdit form = new FormViewEdit(selectedBook))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Update the book in the list
                        books[rowIndex] = form.book;
                        LoadBooks();
                    }
                }
            }

        }
    }
}
