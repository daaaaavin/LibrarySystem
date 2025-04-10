namespace LibrarySystem
{
    partial class YourBooks
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            RDInStock = new RadioButton();
            RdOutOfStock = new RadioButton();
            btnReturn = new Button();
            btnAdd = new Button();
            btnStats = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(649, 157);
            dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(10, 170);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(529, 140);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Book";
            columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Author";
            columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantity in AStock";
            columnHeader3.Width = 260;
            // 
            // RDInStock
            // 
            RDInStock.AutoSize = true;
            RDInStock.Location = new Point(22, 314);
            RDInStock.Margin = new Padding(3, 2, 3, 2);
            RDInStock.Name = "RDInStock";
            RDInStock.Size = new Size(67, 19);
            RDInStock.TabIndex = 2;
            RDInStock.TabStop = true;
            RDInStock.Text = "In Stock";
            RDInStock.UseVisualStyleBackColor = true;
            RDInStock.CheckedChanged += RDInStock_CheckedChanged;
            // 
            // RdOutOfStock
            // 
            RdOutOfStock.AutoSize = true;
            RdOutOfStock.Location = new Point(22, 337);
            RdOutOfStock.Margin = new Padding(3, 2, 3, 2);
            RdOutOfStock.Name = "RdOutOfStock";
            RdOutOfStock.Size = new Size(94, 19);
            RdOutOfStock.TabIndex = 3;
            RdOutOfStock.TabStop = true;
            RdOutOfStock.Text = "Out of  Stock";
            RdOutOfStock.UseVisualStyleBackColor = true;
            RdOutOfStock.CheckedChanged += RdOutOfStock_CheckedChanged;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(665, 37);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(82, 22);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(665, 11);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(665, 63);
            btnStats.Margin = new Padding(3, 2, 3, 2);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(82, 22);
            btnStats.TabIndex = 6;
            btnStats.Text = "Statistics";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // YourBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 367);
            Controls.Add(btnStats);
            Controls.Add(btnAdd);
            Controls.Add(btnReturn);
            Controls.Add(RdOutOfStock);
            Controls.Add(RDInStock);
            Controls.Add(listView1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "YourBooks";
            Text = "Your Books";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private RadioButton RDInStock;
        private RadioButton RdOutOfStock;
        private Button btnReturn;
        private Button btnAdd;
        private Button btnStats;
        private System.Windows.Forms.Timer timer2;
    }
}
