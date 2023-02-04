namespace BookShop_WinForms.FormsAddInfo
{
    partial class AddPromotion
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
            this.tbPromotionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDiscountPercent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPromotionName
            // 
            this.tbPromotionName.Location = new System.Drawing.Point(103, 12);
            this.tbPromotionName.Name = "tbPromotionName";
            this.tbPromotionName.Size = new System.Drawing.Size(120, 20);
            this.tbPromotionName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nudDiscountPercent
            // 
            this.nudDiscountPercent.Location = new System.Drawing.Point(103, 38);
            this.nudDiscountPercent.Name = "nudDiscountPercent";
            this.nudDiscountPercent.Size = new System.Drawing.Size(120, 20);
            this.nudDiscountPercent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DiscountPercent";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(103, 64);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(120, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // AddPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 102);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDiscountPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPromotionName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPromotion";
            this.Text = "AddPromotion";
            this.Load += new System.EventHandler(this.AddPromotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPromotionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDiscountPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAdd;
    }
}