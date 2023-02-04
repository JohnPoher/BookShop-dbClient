namespace BookShop_WinForms
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bAuthorization = new System.Windows.Forms.Button();
            this.rbAdministrator = new System.Windows.Forms.RadioButton();
            this.rbBuyer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(86, 6);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(144, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(86, 32);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(144, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // bAuthorization
            // 
            this.bAuthorization.Location = new System.Drawing.Point(86, 104);
            this.bAuthorization.Name = "bAuthorization";
            this.bAuthorization.Size = new System.Drawing.Size(144, 23);
            this.bAuthorization.TabIndex = 4;
            this.bAuthorization.Text = "Authorization";
            this.bAuthorization.UseVisualStyleBackColor = true;
            this.bAuthorization.Click += new System.EventHandler(this.bAuthorization_Click);
            // 
            // rbAdministrator
            // 
            this.rbAdministrator.AutoSize = true;
            this.rbAdministrator.Checked = true;
            this.rbAdministrator.Location = new System.Drawing.Point(86, 58);
            this.rbAdministrator.Name = "rbAdministrator";
            this.rbAdministrator.Size = new System.Drawing.Size(85, 17);
            this.rbAdministrator.TabIndex = 5;
            this.rbAdministrator.TabStop = true;
            this.rbAdministrator.Text = "Administrator";
            this.rbAdministrator.UseVisualStyleBackColor = true;
            // 
            // rbBuyer
            // 
            this.rbBuyer.AutoSize = true;
            this.rbBuyer.Location = new System.Drawing.Point(86, 81);
            this.rbBuyer.Name = "rbBuyer";
            this.rbBuyer.Size = new System.Drawing.Size(52, 17);
            this.rbBuyer.TabIndex = 6;
            this.rbBuyer.TabStop = true;
            this.rbBuyer.Text = "Buyer";
            this.rbBuyer.UseVisualStyleBackColor = true;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 138);
            this.Controls.Add(this.rbBuyer);
            this.Controls.Add(this.rbAdministrator);
            this.Controls.Add(this.bAuthorization);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bAuthorization;
        private System.Windows.Forms.RadioButton rbAdministrator;
        private System.Windows.Forms.RadioButton rbBuyer;
    }
}