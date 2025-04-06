namespace LibrarySystem
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            checkFavourite = new CheckBox();
            nudTimesRead = new NumericUpDown();
            txtGenre = new TextBox();
            txtAuthor = new TextBox();
            lblTimesRead = new Label();
            lblFavourited = new Label();
            lblGenre = new Label();
            lblPublished = new Label();
            lblAuthor = new Label();
            lblHeader = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            dtpPublished = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nudTimesRead).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(259, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // checkFavourite
            // 
            checkFavourite.AutoSize = true;
            checkFavourite.Location = new Point(119, 211);
            checkFavourite.Name = "checkFavourite";
            checkFavourite.Size = new Size(15, 14);
            checkFavourite.TabIndex = 35;
            checkFavourite.UseVisualStyleBackColor = true;
            // 
            // nudTimesRead
            // 
            nudTimesRead.Font = new Font("Segoe UI", 10F);
            nudTimesRead.Location = new Point(123, 238);
            nudTimesRead.Name = "nudTimesRead";
            nudTimesRead.Size = new Size(61, 25);
            nudTimesRead.TabIndex = 34;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(88, 163);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 30;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(90, 94);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 28;
            // 
            // lblTimesRead
            // 
            lblTimesRead.AutoSize = true;
            lblTimesRead.Font = new Font("Segoe UI", 12F);
            lblTimesRead.Location = new Point(23, 237);
            lblTimesRead.Name = "lblTimesRead";
            lblTimesRead.Size = new Size(93, 21);
            lblTimesRead.TabIndex = 27;
            lblTimesRead.Text = "Times Read:";
            // 
            // lblFavourited
            // 
            lblFavourited.AutoSize = true;
            lblFavourited.Font = new Font("Segoe UI", 12F);
            lblFavourited.Location = new Point(23, 205);
            lblFavourited.Name = "lblFavourited";
            lblFavourited.Size = new Size(90, 21);
            lblFavourited.TabIndex = 25;
            lblFavourited.Text = "Favourited: ";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F);
            lblGenre.Location = new Point(23, 161);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(59, 21);
            lblGenre.TabIndex = 22;
            lblGenre.Text = "Genre: ";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI", 12F);
            lblPublished.Location = new Point(23, 127);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(81, 21);
            lblPublished.TabIndex = 21;
            lblPublished.Text = "Published:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F);
            lblAuthor.Location = new Point(23, 92);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(61, 21);
            lblAuthor.TabIndex = 20;
            lblAuthor.Text = "Author:";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(101, 18);
            lblHeader.TabIndex = 19;
            lblHeader.Text = "Add a Book";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(23, 57);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(46, 21);
            lblTitle.TabIndex = 38;
            lblTitle.Text = "Title: ";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(90, 59);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 39;
            // 
            // dtpPublished
            // 
            dtpPublished.Location = new Point(110, 127);
            dtpPublished.Name = "dtpPublished";
            dtpPublished.Size = new Size(200, 23);
            dtpPublished.TabIndex = 40;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 291);
            Controls.Add(dtpPublished);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(checkFavourite);
            Controls.Add(nudTimesRead);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(lblTimesRead);
            Controls.Add(lblFavourited);
            Controls.Add(lblGenre);
            Controls.Add(lblPublished);
            Controls.Add(lblAuthor);
            Controls.Add(lblHeader);
            Name = "AddBook";
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)nudTimesRead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private CheckBox checkFavourite;
        private NumericUpDown nudTimesRead;
        private TextBox txtGenre;
        private TextBox txtAuthor;
        private Label lblTimesRead;
        private Label lblFavourited;
        private Label lblGenre;
        private Label lblPublished;
        private Label lblAuthor;
        private Label lblHeader;
        private Label lblTitle;
        private TextBox txtTitle;
        private DateTimePicker dtpPublished;
    }
}