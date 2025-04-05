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
            tabFavourites = new TabPage();
            dgvBookView = new DataGridView();
            lblTitle = new Label();
            tabControl1.SuspendLayout();
            tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBooks);
            tabControl1.Controls.Add(tabFavourites);
            tabControl1.Location = new Point(21, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(772, 505);
            tabControl1.TabIndex = 0;
            // 
            // tabBooks
            // 
            tabBooks.Controls.Add(dgvBookView);
            tabBooks.Location = new Point(4, 24);
            tabBooks.Name = "tabBooks";
            tabBooks.Padding = new Padding(3);
            tabBooks.Size = new Size(764, 477);
            tabBooks.TabIndex = 0;
            tabBooks.Text = "Books";
            tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabFavourites
            // 
            tabFavourites.Location = new Point(4, 24);
            tabFavourites.Name = "tabFavourites";
            tabFavourites.Padding = new Padding(3);
            tabFavourites.Size = new Size(696, 477);
            tabFavourites.TabIndex = 1;
            tabFavourites.Text = "Favourites";
            tabFavourites.UseVisualStyleBackColor = true;
            // 
            // dgvBookView
            // 
            dgvBookView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookView.Location = new Point(24, 62);
            dgvBookView.Name = "dgvBookView";
            dgvBookView.Size = new Size(603, 392);
            dgvBookView.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dgvBookView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabBooks;
        private DataGridView dgvBookView;
        private TabPage tabFavourites;
        private Label lblTitle;
    }
}
