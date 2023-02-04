namespace BookShop_WinForms.FormsAddInfo
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
            this.bAdd = new System.Windows.Forms.Button();
            this.nudCountPages = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrimeCost = new System.Windows.Forms.NumericUpDown();
            this.cbIsBookSeries = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCountInStock = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAuthorId = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPromotionId = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPublishingId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimeCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAuthorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromotionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingId)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(103, 271);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // nudCountPages
            // 
            this.nudCountPages.Location = new System.Drawing.Point(103, 38);
            this.nudCountPages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCountPages.Name = "nudCountPages";
            this.nudCountPages.Size = new System.Drawing.Size(100, 20);
            this.nudCountPages.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(103, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CountPages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(103, 65);
            this.nudYear.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(100, 20);
            this.nudYear.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost";
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(103, 91);
            this.nudCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(100, 20);
            this.nudCost.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PrimeCost";
            // 
            // nudPrimeCost
            // 
            this.nudPrimeCost.Location = new System.Drawing.Point(103, 118);
            this.nudPrimeCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrimeCost.Name = "nudPrimeCost";
            this.nudPrimeCost.Size = new System.Drawing.Size(100, 20);
            this.nudPrimeCost.TabIndex = 9;
            // 
            // cbIsBookSeries
            // 
            this.cbIsBookSeries.AutoSize = true;
            this.cbIsBookSeries.Location = new System.Drawing.Point(103, 144);
            this.cbIsBookSeries.Name = "cbIsBookSeries";
            this.cbIsBookSeries.Size = new System.Drawing.Size(88, 17);
            this.cbIsBookSeries.TabIndex = 11;
            this.cbIsBookSeries.Text = "IsBookSeries";
            this.cbIsBookSeries.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CountInStock";
            // 
            // nudCountInStock
            // 
            this.nudCountInStock.Location = new System.Drawing.Point(103, 167);
            this.nudCountInStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCountInStock.Name = "nudCountInStock";
            this.nudCountInStock.Size = new System.Drawing.Size(100, 20);
            this.nudCountInStock.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "AuthorId";
            // 
            // nudAuthorId
            // 
            this.nudAuthorId.Location = new System.Drawing.Point(103, 193);
            this.nudAuthorId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAuthorId.Name = "nudAuthorId";
            this.nudAuthorId.Size = new System.Drawing.Size(100, 20);
            this.nudAuthorId.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "PromotionId";
            // 
            // nudPromotionId
            // 
            this.nudPromotionId.Location = new System.Drawing.Point(103, 219);
            this.nudPromotionId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPromotionId.Name = "nudPromotionId";
            this.nudPromotionId.Size = new System.Drawing.Size(100, 20);
            this.nudPromotionId.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "PublishingId";
            // 
            // nudPublishingId
            // 
            this.nudPublishingId.Location = new System.Drawing.Point(103, 245);
            this.nudPublishingId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPublishingId.Name = "nudPublishingId";
            this.nudPublishingId.Size = new System.Drawing.Size(100, 20);
            this.nudPublishingId.TabIndex = 18;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 305);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPublishingId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudPromotionId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudAuthorId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCountInStock);
            this.Controls.Add(this.cbIsBookSeries);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudPrimeCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCountPages);
            this.Controls.Add(this.bAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCountPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimeCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAuthorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromotionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublishingId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.NumericUpDown nudCountPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrimeCost;
        private System.Windows.Forms.CheckBox cbIsBookSeries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCountInStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAuthorId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPromotionId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPublishingId;
    }
}