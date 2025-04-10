using Microsoft.VisualBasic;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms; // Add this using directive

namespace LibrarySystem
{
    public partial class YourBooks : Form
    {
        private List<Book> books; // Make books a class-level variable
        private Dictionary<String, bool> notifiedBooks; // Track notified books
        private List<Book> returnedBooks = new List<Book>();
        private List<Book> inStock = new List<Book>();
        private List<Book> outOfStock = new List<Book>();

        public YourBooks(List<Book> rentedBooks)
        {
            InitializeComponent();
            books = rentedBooks; // Initialize books with rentedBooks
            notifiedBooks = new Dictionary<String, bool>(); // Initialize notifiedBooks
            notifiedBooks = books.ToDictionary(book => book.Title, book => false);
            PopulateStocks(); // Populate inStock and outOfStock lists
            InitializeTimer();
        }

        private void PopulateStocks()
        {
            inStock.Clear(); // Clear the inStock list before populating
            outOfStock.Clear(); // Clear the outOfStock list before populating
            foreach (Book book in books)
            {
                if (book.IsCheckedOut)
                {
                    outOfStock.Add(book);
                }
                else
                {
                    inStock.Add(book);
                }
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = books;
            timer1.Start(); // Start the timer when the form loads
        }

        

        private void timer1_Tick(object? sender, EventArgs e)
        {
            List<Book> booksToRemove = new List<Book>(); // List to track books to be removed

            foreach (Book book in books)
            {
                if (DateTime.Now >= book.DueDate)
                {
                    var result = MessageBox.Show($"The book '{book.Title}' is overdue.\n\nWould you like to return it?", "Book Overdue", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    booksToRemove.Add(book); // Add book to removal list

                    notifiedBooks[book.Title] = true;
                    // Mark as notified
                }
                else if (book.DueDate.HasValue && DateTime.Now >= book.DueDate.Value.AddMinutes(-2)
                    && DateTime.Now < book.DueDate
                    && !notifiedBooks[book.Title])
                {
                    var result = MessageBox.Show($"The book '{book.Title}' is due soon.\n\nWould you like to return it?", "Book Due Soon", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        book.IsCheckedOut = false; // Mark the book as returned
                    }
                    notifiedBooks[book.Title] = true;
                    // Mark as notified
                }
                
                timer1.Stop(); // Stop the timer after processing
            }


            PopulateStocks(); // Re-populate the in-stock and out-of-stock lists
            // Remove books after iteration
            foreach (Book book in booksToRemove)
            {
                ReturnBook(book);
            }
        }

        private void ReturnBook(Book book)
        {
            books.Remove(book);
            returnedBooks.Add(book); // Track returned books
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;
            notifiedBooks.Remove(book.Title);

            // Show message box when book is placed back in stock
            MessageBox.Show($"The book '{book.Title}' has been returned and is now available for borrowing.", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RDInStock.Checked = true; // Check the radio button for in-stock books
            PopulateStocks(); // Re-populate the in-stock and out-of-stock lists
        }

        private void InitializeTimer()
        {
            // Initialize and configure the timer
            timer1.Interval = 100; // Set the interval to 1000 milliseconds (1 second)
            timer1.Tick += timer1_Tick;
            timer1.Start(); // Start the timer
            timer2.Interval = 30000; // Set the interval to 120000 milliseconds (2 minutes)
            timer2.Tick += timer2_Tick;
            timer2.Start(); // Start the timer
        }

        private void RDInStock_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (RDInStock.Checked)
            {
                foreach (Book book in returnedBooks)
                {
                    ListViewItem item = new ListViewItem(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.Genre);
                    listView1.Items.Add(item);
                }
            }
            

            PopulateStocks(); // Populate the in-stock and out-of-stock lists

            // Populate the ListView with in-stock books
            listView1.Items.Clear();
            foreach (Book book in inStock)
            {
                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Genre);
                listView1.Items.Add(item);
            }
        }

        private void RdOutOfStock_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (RdOutOfStock.Checked)
            {
                // Show books that are not due yet and sort them by due date in ascending order
                List<Book> notDueBooks = books.Where(b => b.DueDate > DateTime.Now).OrderBy(b => b.DueDate).ToList();

                foreach (Book book in notDueBooks)
                {
                    ListViewItem item = new ListViewItem(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.Genre);
                    item.SubItems.Add(book.DueDate.ToString()); // Add due date to the list view
                    listView1.Items.Add(item);
                }
            }
            PopulateStocks(); // Populate the in-stock and out-of-stock lists
                              // Populate the ListView with out-of-stock books
            foreach (Book book in outOfStock)
            {
                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Genre);
                item.SubItems.Add(book.DueDate.ToString()); // Add due date to the list view
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //selects book from data grid view and click button to return it
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Book selectedBook = (Book)dataGridView1.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show($"Are you sure you want to return '{selectedBook.Title}'?", "Return Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ReturnBook(selectedBook);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //when a book is selected in listview1 and click the button, it will be added to the data grid view
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string title = selectedItem.Text;
                string author = selectedItem.SubItems[1].Text;
                string genre = selectedItem.SubItems[2].Text;

                // Prompt user to input the number of days
                string input = Interaction.InputBox("Enter the number of days until the book is due:", "Input Days", "3");
                if (int.TryParse(input, out int days))
                {
                    Book newBook = new Book(0, title, author, genre, DateTime.Now, null, false, true, DateTime.Now.AddDays(days), 0, 0);
                    books.Add(newBook);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = books;

                    // Remove the book from returnedBooks and clear the listView1
                    returnedBooks.RemoveAll(b => b.Title == title && b.Author == author && b.Genre == genre);
                    listView1.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid number of days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to add.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            //if a book is selected in the data grid view and click the button, it will open the stats form and display the book's stats
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Book selectedBook = (Book)dataGridView1.SelectedRows[0].DataBoundItem;
                Form statsForm = new stats(selectedBook);
                statsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a book to view stats.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Generate random messages encouraging users to read rented books
            if (books.Count > 0) // Ensure there are books to choose from
            {
                Random random = new Random();
                int index = random.Next(0, books.Count);
                string message = $"Woaw you courious Mind, Bored? Don't forget to read '{books[index].Title}' by {books[index].Author}!";

                // Display the message in a MessageBox
                MessageBox.Show(message, "Reading Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    

