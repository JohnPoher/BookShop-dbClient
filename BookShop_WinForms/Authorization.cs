using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_WinForms
{
    public partial class Authorization : Form
    {
        private BookShopEntities2 db = null;
        public Authorization()
        {
            InitializeComponent();
            try
            {
                db = new BookShopEntities2();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bAuthorization_Click(object sender, EventArgs e)
        {
            if (rbAdministrator.Checked)
            {
                foreach (var x in db.Admin)
                    if (x.Login == tbLogin.Text && x.Password == tbPassword.Text)
                    {
                        new Form1(this).Show();
                        return;
                    }
                MessageBox.Show("Data entered incorrectly");
            }

            if (rbBuyer.Checked)
            {
                foreach (var x in db.Buyers)
                    if (x.Login == tbLogin.Text && x.Password == tbPassword.Text)
                    {
                        new Form2(this,x.Id).Show();
                        return;
                    }
                MessageBox.Show("Data entered incorrectly");
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
