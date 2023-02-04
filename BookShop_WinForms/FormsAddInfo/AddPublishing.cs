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
    public partial class AddPublishing : Form
    {
        private BookShopEntities2 db;
        public AddPublishing(BookShopEntities2 Db)
        {
            InitializeComponent();
            db = Db;
        }

        private void AddPublishing_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try {
                db.Publishing.Add(new Publishing { Name = tbName.Text, Address = tbAddress.Text });
                db.SaveChanges();
                tbName.Text=string.Empty;
                tbAddress.Text=string.Empty;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
