namespace LibrarySystem
{
    public partial class Form1 : Form
    {

        List<Book> books;
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
        }

        private List<Book> GenerateSampleBooks()
        {
            return new List<Book>
            {
                new Book(1, "Ready Player One", "Ernest Cline", "Science Fiction", DateTime.Now, new DateTime(2011, 8, 16), true, false),
                new Book(2, "The Outsiders", "S. E. Hinton", "Young Adult", DateTime.Now, new DateTime(1967, 4, 24), false, false),
                new Book(3, "The Maze Runner", "James Dashner", "Dystopian", DateTime.Now, new DateTime(2009, 10, 6), true, false),
                new Book(4, "Dune", "Frank Herbert", "Science Fiction", DateTime.Now, new DateTime(1965, 8, 1), true, false),
                new Book(5, "Brave New World", "Aldous Huxley", "Dystopian", DateTime.Now, new DateTime(1932, 1, 1), false, false),
                new Book(6, "Moby Dick", "Herman Melville", "Adventure", DateTime.Now, new DateTime(1851, 10, 18), false, false)
            };
        }

        private void LoadBooks()
        {
            books = GenerateSampleBooks();
            dgvBooks.DataSource = null; //Set to null incase the data source is already set
            dgvBooks.DataSource = books; //Import books to data grid
        }
    }
}
