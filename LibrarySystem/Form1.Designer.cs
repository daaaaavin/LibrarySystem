namespace LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabBooks = new TabPage();
            cmbSort = new ComboBox();
            lblSearchBy = new Label();
            rdoSearchByGenre = new RadioButton();
            rdoSearchByAuthor = new RadioButton();
            rdoSearchByName = new RadioButton();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnExport = new Button();
            btnImport = new Button();
            dgvBookView = new DataGridView();
            tabFavourites = new TabPage();
            dgvFavourites = new DataGridView();
            tabYourBooks = new TabPage();
            lblTitle = new Label();
            btnAddBook = new Button();
            tabControl1.SuspendLayout();
            tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookView).BeginInit();
            tabFavourites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFavourites).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBooks);
            tabControl1.Controls.Add(tabFavourites);
            tabControl1.Controls.Add(tabYourBooks);
            tabControl1.Location = new Point(21, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(772, 505);
            tabControl1.TabIndex = 0;
            // 
            // tabBooks
            // 
            tabBooks.Controls.Add(btnAddBook);
            tabBooks.Controls.Add(cmbSort);
            tabBooks.Controls.Add(lblSearchBy);
            tabBooks.Controls.Add(rdoSearchByGenre);
            tabBooks.Controls.Add(rdoSearchByAuthor);
            tabBooks.Controls.Add(rdoSearchByName);
            tabBooks.Controls.Add(btnSearch);
            tabBooks.Controls.Add(txtSearch);
            tabBooks.Controls.Add(btnExport);
            tabBooks.Controls.Add(btnImport);
            tabBooks.Controls.Add(dgvBookView);
            tabBooks.Location = new Point(4, 24);
            tabBooks.Name = "tabBooks";
            tabBooks.Padding = new Padding(3);
            tabBooks.Size = new Size(764, 477);
            tabBooks.TabIndex = 0;
            tabBooks.Text = "Books";
            tabBooks.UseVisualStyleBackColor = true;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Title", "Author", "Genre", "Published", "Date Added" });
            cmbSort.Location = new Point(367, 58);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(121, 23);
            cmbSort.TabIndex = 9;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.Location = new Point(6, 14);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(61, 15);
            lblSearchBy.TabIndex = 8;
            lblSearchBy.Text = "Search by:";
            // 
            // rdoSearchByGenre
            // 
            rdoSearchByGenre.AutoSize = true;
            rdoSearchByGenre.Location = new Point(137, 32);
            rdoSearchByGenre.Name = "rdoSearchByGenre";
            rdoSearchByGenre.Size = new Size(56, 19);
            rdoSearchByGenre.TabIndex = 7;
            rdoSearchByGenre.TabStop = true;
            rdoSearchByGenre.Text = "Genre";
            rdoSearchByGenre.UseVisualStyleBackColor = true;
            // 
            // rdoSearchByAuthor
            // 
            rdoSearchByAuthor.AutoSize = true;
            rdoSearchByAuthor.Location = new Point(69, 32);
            rdoSearchByAuthor.Name = "rdoSearchByAuthor";
            rdoSearchByAuthor.Size = new Size(62, 19);
            rdoSearchByAuthor.TabIndex = 6;
            rdoSearchByAuthor.TabStop = true;
            rdoSearchByAuthor.Text = "Author";
            rdoSearchByAuthor.UseVisualStyleBackColor = true;
            // 
            // rdoSearchByName
            // 
            rdoSearchByName.AutoSize = true;
            rdoSearchByName.Location = new Point(6, 32);
            rdoSearchByName.Name = "rdoSearchByName";
            rdoSearchByName.Size = new Size(57, 19);
            rdoSearchByName.TabIndex = 5;
            rdoSearchByName.TabStop = true;
            rdoSearchByName.Text = "Name";
            rdoSearchByName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(286, 57);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 57);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Book...";
            txtSearch.Size = new Size(277, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(646, 56);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(112, 23);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export To File";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(646, 6);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(112, 23);
            btnImport.TabIndex = 1;
            btnImport.Text = "Import From File";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // dgvBookView
            // 
            dgvBookView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookView.Location = new Point(-4, 85);
            dgvBookView.Name = "dgvBookView";
            dgvBookView.Size = new Size(765, 392);
            dgvBookView.TabIndex = 0;
            // 
            // tabFavourites
            // 
            tabFavourites.Controls.Add(dgvFavourites);
            tabFavourites.Location = new Point(4, 24);
            tabFavourites.Name = "tabFavourites";
            tabFavourites.Padding = new Padding(3);
            tabFavourites.Size = new Size(764, 477);
            tabFavourites.TabIndex = 1;
            tabFavourites.Text = "Favourites";
            tabFavourites.UseVisualStyleBackColor = true;
            // 
            // dgvFavourites
            // 
            dgvFavourites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFavourites.Location = new Point(0, 91);
            dgvFavourites.Name = "dgvFavourites";
            dgvFavourites.Size = new Size(758, 386);
            dgvFavourites.TabIndex = 0;
            // 
            // tabYourBooks
            // 
            tabYourBooks.Location = new Point(4, 24);
            tabYourBooks.Name = "tabYourBooks";
            tabYourBooks.Padding = new Padding(3);
            tabYourBooks.Size = new Size(764, 477);
            tabYourBooks.TabIndex = 2;
            tabYourBooks.Text = "Your Books";
            tabYourBooks.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("UD Digi Kyokasho NP-B", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblTitle.Location = new Point(21, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(247, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Your Library";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(565, 6);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 10;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 613);
            Controls.Add(lblTitle);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Library";
            tabControl1.ResumeLayout(false);
            tabBooks.ResumeLayout(false);
            tabBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookView).EndInit();
            tabFavourites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFavourites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabBooks;
        private DataGridView dgvBookView;
        private TabPage tabFavourites;
        private Label lblTitle;
        private DataGridView dgvFavourites;
        private Button btnImport;
        private Button btnExport;
        private TextBox txtSearch;
        private Label lblSearchBy;
        private RadioButton rdoSearchByGenre;
        private RadioButton rdoSearchByAuthor;
        private RadioButton rdoSearchByName;
        private Button btnSearch;
        private TabPage tabYourBooks;
        private ComboBox cmbSort;
        private Button btnAddBook;
    }
}
