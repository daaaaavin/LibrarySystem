namespace LibrarySystem
{
    partial class FormViewEdit : Form
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
            label1 = new Label();
            lblAuthor = new Label();
            lblPublished = new Label();
            lblGenre = new Label();
            lblReturnDate = new Label();
            lblStatus = new Label();
            lblFavourited = new Label();
            lblDateAdded = new Label();
            lblTimesRead = new Label();
            txtAuthor = new TextBox();
            txtPublished = new TextBox();
            txtGenre = new TextBox();
            txtDateAdded = new TextBox();
            txtStatus = new TextBox();
            txtReturn = new TextBox();
            nudTimesRead = new NumericUpDown();
            checkFavourite = new CheckBox();
            btnEditDetails = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTimesRead).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 0;
            label1.Text = "Details";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F);
            lblAuthor.Location = new Point(12, 77);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(61, 21);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author:";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI", 12F);
            lblPublished.Location = new Point(12, 112);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(81, 21);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F);
            lblGenre.Location = new Point(12, 146);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(59, 21);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "Genre: ";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 12F);
            lblReturnDate.Location = new Point(12, 221);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(96, 21);
            lblReturnDate.TabIndex = 4;
            lblReturnDate.Text = "Return Date:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(12, 186);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 21);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status:";
            // 
            // lblFavourited
            // 
            lblFavourited.AutoSize = true;
            lblFavourited.Font = new Font("Segoe UI", 12F);
            lblFavourited.Location = new Point(12, 256);
            lblFavourited.Name = "lblFavourited";
            lblFavourited.Size = new Size(90, 21);
            lblFavourited.TabIndex = 6;
            lblFavourited.Text = "Favourited: ";
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.Font = new Font("Segoe UI", 12F);
            lblDateAdded.Location = new Point(12, 324);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(94, 21);
            lblDateAdded.TabIndex = 7;
            lblDateAdded.Text = "Date Added:";
            // 
            // lblTimesRead
            // 
            lblTimesRead.AutoSize = true;
            lblTimesRead.Font = new Font("Segoe UI", 12F);
            lblTimesRead.Location = new Point(12, 290);
            lblTimesRead.Name = "lblTimesRead";
            lblTimesRead.Size = new Size(93, 21);
            lblTimesRead.TabIndex = 8;
            lblTimesRead.Text = "Times Read:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(79, 79);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 9;
            // 
            // txtPublished
            // 
            txtPublished.Location = new Point(99, 114);
            txtPublished.Name = "txtPublished";
            txtPublished.ReadOnly = true;
            txtPublished.Size = new Size(100, 23);
            txtPublished.TabIndex = 10;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(77, 148);
            txtGenre.Name = "txtGenre";
            txtGenre.ReadOnly = true;
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 11;
            // 
            // txtDateAdded
            // 
            txtDateAdded.Location = new Point(112, 326);
            txtDateAdded.Name = "txtDateAdded";
            txtDateAdded.ReadOnly = true;
            txtDateAdded.Size = new Size(100, 23);
            txtDateAdded.TabIndex = 12;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(73, 188);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 13;
            // 
            // txtReturn
            // 
            txtReturn.Location = new Point(112, 223);
            txtReturn.Name = "txtReturn";
            txtReturn.ReadOnly = true;
            txtReturn.Size = new Size(100, 23);
            txtReturn.TabIndex = 14;
            // 
            // nudTimesRead
            // 
            nudTimesRead.Font = new Font("Segoe UI", 10F);
            nudTimesRead.Location = new Point(111, 290);
            nudTimesRead.Name = "nudTimesRead";
            nudTimesRead.ReadOnly = true;
            nudTimesRead.Size = new Size(61, 25);
            nudTimesRead.TabIndex = 15;
            // 
            // checkFavourite
            // 
            checkFavourite.AutoSize = true;
            checkFavourite.Enabled = false;
            checkFavourite.Location = new Point(99, 262);
            checkFavourite.Name = "checkFavourite";
            checkFavourite.Size = new Size(15, 14);
            checkFavourite.TabIndex = 16;
            checkFavourite.UseVisualStyleBackColor = true;
            // 
            // btnEditDetails
            // 
            btnEditDetails.Location = new Point(18, 380);
            btnEditDetails.Name = "btnEditDetails";
            btnEditDetails.Size = new Size(75, 23);
            btnEditDetails.TabIndex = 17;
            btnEditDetails.Text = "Edit Details";
            btnEditDetails.UseVisualStyleBackColor = true;
            btnEditDetails.Click += btnEditDetails_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(252, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormViewEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 415);
            Controls.Add(btnSave);
            Controls.Add(btnEditDetails);
            Controls.Add(checkFavourite);
            Controls.Add(nudTimesRead);
            Controls.Add(txtReturn);
            Controls.Add(txtStatus);
            Controls.Add(txtDateAdded);
            Controls.Add(txtGenre);
            Controls.Add(txtPublished);
            Controls.Add(txtAuthor);
            Controls.Add(lblTimesRead);
            Controls.Add(lblDateAdded);
            Controls.Add(lblFavourited);
            Controls.Add(lblStatus);
            Controls.Add(lblReturnDate);
            Controls.Add(lblGenre);
            Controls.Add(lblPublished);
            Controls.Add(lblAuthor);
            Controls.Add(label1);
            Name = "FormViewEdit";
            Text = "FormViewEdit";
            ((System.ComponentModel.ISupportInitialize)nudTimesRead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAuthor;
        private Label lblPublished;
        private Label lblGenre;
        private Label lblReturnDate;
        private Label lblStatus;
        private Label lblFavourited;
        private Label lblDateAdded;
        private Label lblTimesRead;
        private TextBox txtAuthor;
        private TextBox txtPublished;
        private TextBox txtGenre;
        private TextBox txtDateAdded;
        private TextBox txtStatus;
        private TextBox txtReturn;
        private NumericUpDown nudTimesRead;
        private CheckBox checkFavourite;
        private Button btnEditDetails;
        private Button btnSave;
    }
}