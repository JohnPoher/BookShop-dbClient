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
    public partial class AddBook : Form
    {
        private BookShopEntities2 db;
        public AddBook(BookShopEntities2 Db)
        {
            InitializeComponent();

            db = Db;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try {
                var book = new Books
                {
                    Name = tbName.Text,
                    CountPages = (int)nudCountPages.Value,
                    Year = (int)nudYear.Value,
                    Cost = (int)nudCost.Value,
                    PrimeCost = (int)nudPrimeCost.Value,
                    IsBookSeries = cbIsBookSeries.Enabled,
                    CountInStock = (int)nudCountInStock.Value,
                    Authors = db.Authors.Where(x => x.Id == (int)nudAuthorId.Value).First(),
                    AuthorId= (int)nudAuthorId.Value,
                    Promotions = db.Promotions.Where(x => x.Id == (int)nudPromotionId.Value).First(),
                    PromotionId = (int)nudPromotionId.Value,
                    Publishing = db.Publishing.Where(x => x.Id == (int)nudPublishingId.Value).First(),
                    PublishingId = (int)nudPublishingId.Value
                };

                db.Books.Add(book);
                db.SaveChanges();

                tbName.Text=string.Empty;
                nudCountPages.Value = 0;
                nudYear.Value = 0;
                nudCost.Value = 0;
                nudPrimeCost.Value = 0;
                cbIsBookSeries.Enabled= false;
                nudCountInStock.Value = 0;
                nudAuthorId.Value = 0;
                nudPromotionId.Value = 0;
                nudPublishingId.Value = 0;
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }
    }
}
