using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_WinForms.FormsAddInfo
{
    public partial class AddAuthor : Form
    {
        private BookShopEntities2 db;
        public AddAuthor(BookShopEntities2 Db)
        {
            InitializeComponent();
            this.db = Db;
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try {
                db.Authors.Add(new Authors { Name =tbName.Text, Surname =tbSurname.Text});
                tbName.Text = string.Empty;
                tbSurname.Text=string.Empty;
                db.SaveChanges();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
