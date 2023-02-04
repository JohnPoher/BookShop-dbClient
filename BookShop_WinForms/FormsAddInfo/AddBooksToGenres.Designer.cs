namespace BookShop_WinForms.FormsAddInfo
{
    partial class AddBooksToGenres
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBookId = new System.Windows.Forms.NumericUpDown();
            this.nudGenreId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBookId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenreId)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(104, 64);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 23);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "BookId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "GenreId";
            // 
            // nudBookId
            // 
            this.nudBookId.Location = new System.Drawing.Point(104, 12);
            this.nudBookId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudBookId.Name = "nudBookId";
            this.nudBookId.Size = new System.Drawing.Size(120, 20);
            this.nudBookId.TabIndex = 15;
            // 
            // nudGenreId
            // 
            this.nudGenreId.Location = new System.Drawing.Point(104, 38);
            this.nudGenreId.Name = "nudGenreId";
            this.nudGenreId.Size = new System.Drawing.Size(120, 20);
            this.nudGenreId.TabIndex = 16;
            // 
            // AddBooksToGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 99);
            this.Controls.Add(this.nudGenreId);
            this.Controls.Add(this.nudBookId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBooksToGenres";
            this.Text = "AddBooksToGenres";
            ((System.ComponentModel.ISupportInitialize)(this.nudBookId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGenreId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBookId;
        private System.Windows.Forms.NumericUpDown nudGenreId;
    }
}