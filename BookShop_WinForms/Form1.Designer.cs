namespace BookShop_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCurrentTable = new System.Windows.Forms.DataGridView();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.lTables = new System.Windows.Forms.Label();
            this.bSaveChanges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGenre = new System.Windows.Forms.RadioButton();
            this.rbAuthor = new System.Windows.Forms.RadioButton();
            this.rbBookName = new System.Windows.Forms.RadioButton();
            this.bFindBook = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.nudMinYear = new System.Windows.Forms.NumericUpDown();
            this.bfindMinYear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQuery = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bFindByDate = new System.Windows.Forms.Button();
            this.rb365days = new System.Windows.Forms.RadioButton();
            this.rb7days = new System.Windows.Forms.RadioButton();
            this.rb30days = new System.Windows.Forms.RadioButton();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAddTo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinYear)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurrentTable
            // 
            this.dgvCurrentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentTable.Location = new System.Drawing.Point(12, 12);
            this.dgvCurrentTable.Name = "dgvCurrentTable";
            this.dgvCurrentTable.Size = new System.Drawing.Size(824, 576);
            this.dgvCurrentTable.TabIndex = 0;
            // 
            // cbTables
            // 
            this.cbTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Items.AddRange(new object[] {
            "Authors",
            "Books",
            "BooksToGenres",
            "Genres",
            "Promotions",
            "Publishing",
            "Sales",
            "Buyers",
            "Basket"});
            this.cbTables.Location = new System.Drawing.Point(913, 39);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(102, 21);
            this.cbTables.TabIndex = 1;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // lTables
            // 
            this.lTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lTables.AutoSize = true;
            this.lTables.Location = new System.Drawing.Point(846, 42);
            this.lTables.Name = "lTables";
            this.lTables.Size = new System.Drawing.Size(61, 13);
            this.lTables.TabIndex = 2;
            this.lTables.Text = "ShowTable";
            // 
            // bSaveChanges
            // 
            this.bSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveChanges.Location = new System.Drawing.Point(913, 66);
            this.bSaveChanges.Name = "bSaveChanges";
            this.bSaveChanges.Size = new System.Drawing.Size(102, 23);
            this.bSaveChanges.TabIndex = 3;
            this.bSaveChanges.Text = "Save Changes";
            this.bSaveChanges.UseVisualStyleBackColor = true;
            this.bSaveChanges.Click += new System.EventHandler(this.bSaveChanges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbGenre);
            this.groupBox1.Controls.Add(this.rbAuthor);
            this.groupBox1.Controls.Add(this.rbBookName);
            this.groupBox1.Controls.Add(this.bFindBook);
            this.groupBox1.Controls.Add(this.tbFind);
            this.groupBox1.Location = new System.Drawing.Point(842, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Book";
            // 
            // rbGenre
            // 
            this.rbGenre.AutoSize = true;
            this.rbGenre.Location = new System.Drawing.Point(7, 66);
            this.rbGenre.Name = "rbGenre";
            this.rbGenre.Size = new System.Drawing.Size(54, 17);
            this.rbGenre.TabIndex = 13;
            this.rbGenre.TabStop = true;
            this.rbGenre.Text = "Genre";
            this.rbGenre.UseVisualStyleBackColor = true;
            // 
            // rbAuthor
            // 
            this.rbAuthor.AutoSize = true;
            this.rbAuthor.Location = new System.Drawing.Point(7, 43);
            this.rbAuthor.Name = "rbAuthor";
            this.rbAuthor.Size = new System.Drawing.Size(56, 17);
            this.rbAuthor.TabIndex = 12;
            this.rbAuthor.TabStop = true;
            this.rbAuthor.Text = "Author";
            this.rbAuthor.UseVisualStyleBackColor = true;
            // 
            // rbBookName
            // 
            this.rbBookName.AutoSize = true;
            this.rbBookName.Location = new System.Drawing.Point(7, 20);
            this.rbBookName.Name = "rbBookName";
            this.rbBookName.Size = new System.Drawing.Size(78, 17);
            this.rbBookName.TabIndex = 11;
            this.rbBookName.TabStop = true;
            this.rbBookName.Text = "BookName";
            this.rbBookName.UseVisualStyleBackColor = true;
            // 
            // bFindBook
            // 
            this.bFindBook.Location = new System.Drawing.Point(7, 115);
            this.bFindBook.Name = "bFindBook";
            this.bFindBook.Size = new System.Drawing.Size(166, 23);
            this.bFindBook.TabIndex = 10;
            this.bFindBook.Text = "Find";
            this.bFindBook.UseVisualStyleBackColor = true;
            this.bFindBook.Click += new System.EventHandler(this.bFindBook_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(7, 89);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(166, 20);
            this.tbFind.TabIndex = 8;
            // 
            // nudMinYear
            // 
            this.nudMinYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinYear.Location = new System.Drawing.Point(913, 250);
            this.nudMinYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudMinYear.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudMinYear.Name = "nudMinYear";
            this.nudMinYear.Size = new System.Drawing.Size(102, 20);
            this.nudMinYear.TabIndex = 5;
            this.nudMinYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // bfindMinYear
            // 
            this.bfindMinYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bfindMinYear.Location = new System.Drawing.Point(913, 276);
            this.bfindMinYear.Name = "bfindMinYear";
            this.bfindMinYear.Size = new System.Drawing.Size(102, 23);
            this.bfindMinYear.TabIndex = 14;
            this.bfindMinYear.Text = "Find";
            this.bfindMinYear.UseVisualStyleBackColor = true;
            this.bfindMinYear.Click += new System.EventHandler(this.bfindMinYear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "MinYear";
            // 
            // cbQuery
            // 
            this.cbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuery.FormattingEnabled = true;
            this.cbQuery.Items.AddRange(new object[] {
            "Top5 BestSeller",
            "Top5 popular Authors",
            "Top5 popular Genre"});
            this.cbQuery.Location = new System.Drawing.Point(7, 111);
            this.cbQuery.Name = "cbQuery";
            this.cbQuery.Size = new System.Drawing.Size(166, 21);
            this.cbQuery.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bFindByDate);
            this.groupBox2.Controls.Add(this.rb365days);
            this.groupBox2.Controls.Add(this.rb7days);
            this.groupBox2.Controls.Add(this.rb30days);
            this.groupBox2.Controls.Add(this.rbToday);
            this.groupBox2.Controls.Add(this.cbQuery);
            this.groupBox2.Location = new System.Drawing.Point(842, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 171);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // bFindByDate
            // 
            this.bFindByDate.Location = new System.Drawing.Point(10, 138);
            this.bFindByDate.Name = "bFindByDate";
            this.bFindByDate.Size = new System.Drawing.Size(166, 23);
            this.bFindByDate.TabIndex = 19;
            this.bFindByDate.Text = "Find";
            this.bFindByDate.UseVisualStyleBackColor = true;
            this.bFindByDate.Click += new System.EventHandler(this.bFindByDate_Click);
            // 
            // rb365days
            // 
            this.rb365days.AutoSize = true;
            this.rb365days.Location = new System.Drawing.Point(10, 88);
            this.rb365days.Name = "rb365days";
            this.rb365days.Size = new System.Drawing.Size(68, 17);
            this.rb365days.TabIndex = 20;
            this.rb365days.Text = "365 days";
            this.rb365days.UseVisualStyleBackColor = true;
            // 
            // rb7days
            // 
            this.rb7days.AutoSize = true;
            this.rb7days.Location = new System.Drawing.Point(10, 42);
            this.rb7days.Name = "rb7days";
            this.rb7days.Size = new System.Drawing.Size(56, 17);
            this.rb7days.TabIndex = 19;
            this.rb7days.Text = "7 days";
            this.rb7days.UseVisualStyleBackColor = true;
            // 
            // rb30days
            // 
            this.rb30days.AutoSize = true;
            this.rb30days.Location = new System.Drawing.Point(10, 65);
            this.rb30days.Name = "rb30days";
            this.rb30days.Size = new System.Drawing.Size(62, 17);
            this.rb30days.TabIndex = 18;
            this.rb30days.Text = "30 days";
            this.rb30days.UseVisualStyleBackColor = true;
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Checked = true;
            this.rbToday.Location = new System.Drawing.Point(10, 19);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(55, 17);
            this.rbToday.TabIndex = 14;
            this.rbToday.TabStop = true;
            this.rbToday.Text = "Today";
            this.rbToday.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "AddTo";
            // 
            // cbAddTo
            // 
            this.cbAddTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddTo.FormattingEnabled = true;
            this.cbAddTo.Items.AddRange(new object[] {
            "Authors",
            "Books",
            "BooksToGenres",
            "Genres",
            "Promotions",
            "Publishing",
            "Sales",
            "Buyers",
            "Basket"});
            this.cbAddTo.Location = new System.Drawing.Point(913, 12);
            this.cbAddTo.Name = "cbAddTo";
            this.cbAddTo.Size = new System.Drawing.Size(102, 21);
            this.cbAddTo.TabIndex = 21;
            this.cbAddTo.SelectedIndexChanged += new System.EventHandler(this.cbAddTo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 600);
            this.Controls.Add(this.cbAddTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bfindMinYear);
            this.Controls.Add(this.nudMinYear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bSaveChanges);
            this.Controls.Add(this.lTables);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.dgvCurrentTable);
            this.Name = "Form1";
            this.Text = "Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinYear)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrentTable;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label lTables;
        private System.Windows.Forms.Button bSaveChanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bFindBook;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.RadioButton rbGenre;
        private System.Windows.Forms.RadioButton rbAuthor;
        private System.Windows.Forms.RadioButton rbBookName;
        private System.Windows.Forms.NumericUpDown nudMinYear;
        private System.Windows.Forms.Button bfindMinYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQuery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bFindByDate;
        private System.Windows.Forms.RadioButton rb365days;
        private System.Windows.Forms.RadioButton rb7days;
        private System.Windows.Forms.RadioButton rb30days;
        private System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAddTo;
    }
}

