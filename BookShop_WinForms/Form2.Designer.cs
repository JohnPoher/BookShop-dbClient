
namespace BookShop_WinForms
{
	partial class Form2
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
            this.dgvCurrentTable = new System.Windows.Forms.DataGridView();
            this.bShowAllBooks = new System.Windows.Forms.Button();
            this.bShowBasket = new System.Windows.Forms.Button();
            this.bAddToBasket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.nudBookId = new System.Windows.Forms.NumericUpDown();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookId)).BeginInit();
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
            this.dgvCurrentTable.Size = new System.Drawing.Size(632, 426);
            this.dgvCurrentTable.TabIndex = 0;
            // 
            // bShowAllBooks
            // 
            this.bShowAllBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bShowAllBooks.Location = new System.Drawing.Point(651, 13);
            this.bShowAllBooks.Name = "bShowAllBooks";
            this.bShowAllBooks.Size = new System.Drawing.Size(145, 23);
            this.bShowAllBooks.TabIndex = 1;
            this.bShowAllBooks.Text = "Show Stock";
            this.bShowAllBooks.UseVisualStyleBackColor = true;
            this.bShowAllBooks.Click += new System.EventHandler(this.bShowAllBooks_Click);
            // 
            // bShowBasket
            // 
            this.bShowBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bShowBasket.Location = new System.Drawing.Point(651, 43);
            this.bShowBasket.Name = "bShowBasket";
            this.bShowBasket.Size = new System.Drawing.Size(145, 23);
            this.bShowBasket.TabIndex = 2;
            this.bShowBasket.Text = "Show Basket";
            this.bShowBasket.UseVisualStyleBackColor = true;
            this.bShowBasket.Click += new System.EventHandler(this.bShowBasket_Click);
            // 
            // bAddToBasket
            // 
            this.bAddToBasket.Location = new System.Drawing.Point(6, 66);
            this.bAddToBasket.Name = "bAddToBasket";
            this.bAddToBasket.Size = new System.Drawing.Size(133, 23);
            this.bAddToBasket.TabIndex = 3;
            this.bAddToBasket.Text = "AddToBaket";
            this.bAddToBasket.UseVisualStyleBackColor = true;
            this.bAddToBasket.Click += new System.EventHandler(this.bAddToBasket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BookId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count";
            // 
            // bBuy
            // 
            this.bBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBuy.Location = new System.Drawing.Point(651, 205);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(146, 23);
            this.bBuy.TabIndex = 6;
            this.bBuy.Text = "Buy";
            this.bBuy.UseVisualStyleBackColor = true;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudCount);
            this.groupBox1.Controls.Add(this.nudBookId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bAddToBasket);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(651, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 98);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(63, 40);
            this.nudCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(74, 20);
            this.nudCount.TabIndex = 7;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBookId
            // 
            this.nudBookId.Location = new System.Drawing.Point(63, 14);
            this.nudBookId.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBookId.Name = "nudBookId";
            this.nudBookId.Size = new System.Drawing.Size(74, 20);
            this.nudBookId.TabIndex = 6;
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(651, 176);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(146, 23);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear Basket";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bBuy);
            this.Controls.Add(this.bShowBasket);
            this.Controls.Add(this.bShowAllBooks);
            this.Controls.Add(this.dgvCurrentTable);
            this.Name = "Form2";
            this.Text = "Buyer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookId)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCurrentTable;
		private System.Windows.Forms.Button bShowAllBooks;
		private System.Windows.Forms.Button bShowBasket;
		private System.Windows.Forms.Button bAddToBasket;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bBuy;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nudCount;
		private System.Windows.Forms.NumericUpDown nudBookId;
        private System.Windows.Forms.Button bClear;
    }
}