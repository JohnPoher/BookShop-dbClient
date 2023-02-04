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
    public partial class AddGenres : Form
    {
        private BookShopEntities2 db;
        public AddGenres(BookShopEntities2 Db)
        {
            InitializeComponent();
            db = Db;
        }

        private void Genres_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try {
                db.Genres.Add(new Genres { Name = tbGenreName.Text });
                db.SaveChanges();
                tbGenreName.Text=string.Empty;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
