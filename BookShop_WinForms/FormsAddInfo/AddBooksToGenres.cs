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
    public partial class AddBooksToGenres : Form
    {
        private BookShopEntities2 db;
        public AddBooksToGenres(BookShopEntities2 Db)
        {
            InitializeComponent();
            db = Db;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try {
                db.BooksToGenres.Add(new BooksToGenres { BookId = (int)nudBookId.Value, 
                    Books= db.Books.Where(x=>x.Id== (int)nudBookId.Value).First(), 
                    GenreId = (int)nudGenreId.Value,
                    Genres=db.Genres.Where(x=>x.Id== (int)nudGenreId.Value).First() });
                db.SaveChanges();

                nudBookId.Value = 0;
                nudGenreId.Value = 0;            
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }
    }
}
