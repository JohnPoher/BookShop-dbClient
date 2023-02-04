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
	public partial class Form2 : Form
	{
		private BookShopEntities2 db;
		private int BuyerId;
		private Authorization authorization;

		public Form2(Authorization Authorization, int id)
		{
			InitializeComponent();
			db = new BookShopEntities2();
			BuyerId = id;
			authorization = Authorization;
			authorization.Hide();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			try {
                dgvCurrentTable.DataSource = db.Books
					.Select(x => new { Id = x.Id, 
						Name = x.Name, 
						Cost = (int)x.Cost - ((int)x.Cost / 100 * x.Promotions.DiscountPercent), 
						DiscontPercent = x.Promotions.DiscountPercent, 
						Author = x.Authors.Name + " " + x.Authors.Surname, 
						Year = x.Year, 
						Publisher = x.Publishing.Name })
					.ToList();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void bShowBasket_Click(object sender, EventArgs e)
		{
			try {
				dgvCurrentTable.DataSource = db.Basket
					.Where(x => x.Buyers.Id == BuyerId)
					.Select(x=>new {Id= x.BookId, 
						Name = x.Books.Name, 
						Cost=(int)x.Books.Cost-((int)x.Books.Cost/100*x.Books.Promotions.DiscountPercent)})
					.ToList();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void bShowAllBooks_Click(object sender, EventArgs e)
		{
			try
			{
				dgvCurrentTable.DataSource = db.Books
					.Select(x => new { Id = x.Id, 
						Name = x.Name, 
						Cost = x.Cost, 
						DiscontPercent = x.Promotions.DiscountPercent, 
						Author= x.Authors.Name+ " "+x.Authors.Surname, 
						Year= x.Year, 
						Publisher = x.Publishing.Name})
					.ToList();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void bAddToBasket_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < (int)nudCount.Value; i++)
				{
                    var basket = new Basket
                    {
                        BookId = (int)nudBookId.Value,
                        Books = db.Books.Where(x => x.Id == (int)nudBookId.Value).First(),
                        BuyerId = this.BuyerId,
                        Buyers = db.Buyers.Where(x => x.Id == BuyerId).First()
                    };
                    db.Basket.Add(basket);
				}
				db.SaveChanges();

				nudBookId.Value = 0;
				nudCount.Value = 1;
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void bBuy_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (var x in db.Basket.Where(x => x.BuyerId == this.BuyerId))
				{ 
					var sale = new Sales { BookId = x.BookId, 
						Books = x.Books, 
						BuyerId = this.BuyerId, 
						Buyers =db.Buyers.Where(b=>b.Id==BuyerId).First(), 
						Date=DateTime.Now, 
						Cost=(int)x.Books.Cost- ((int)x.Books.Cost/100 * x.Books.Promotions.DiscountPercent)}; 
					db.Sales.Add(sale);

					var bookChange = db.Books.Where(b => b.Id == x.BookId).First();
					bookChange.CountInStock--;
					db.Basket.Remove(x);
				}

                db.SaveChanges();
            }
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
			authorization.Close();
			db.Dispose();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var x in db.Basket.Where(x => x.BuyerId == this.BuyerId))
                {
                    db.Basket.Remove(x);
                }

                db.SaveChanges();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
