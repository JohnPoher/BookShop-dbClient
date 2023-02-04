using BookShop_WinForms.FormsAddInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace BookShop_WinForms
{
    public partial class Form1 : Form
    {
        private BookShopEntities2 db = null;
        private Authorization Authorization;
        public Form1(Authorization authorization)
        {
            InitializeComponent();

            Authorization=authorization;
            Authorization.Hide();

            try {
                db = new BookShopEntities2();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Authorization.Close();
            db.Dispose();
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (cbTables.SelectedIndex==0) //Authors
                    dgvCurrentTable.DataSource= db.Authors.ToList();

                if (cbTables.SelectedIndex == 1) //Books
                    dgvCurrentTable.DataSource = db.Books.ToList();

                if (cbTables.SelectedIndex == 2) //BooksToGenres
                    dgvCurrentTable.DataSource = db.BooksToGenres.ToList();

                if (cbTables.SelectedIndex == 3) //Genres
                    dgvCurrentTable.DataSource = db.Genres.ToList();

                if (cbTables.SelectedIndex == 4) //Promotions
                    dgvCurrentTable.DataSource = db.Promotions.ToList();

                if (cbTables.SelectedIndex == 5) //Publishing
                    dgvCurrentTable.DataSource = db.Publishing.ToList();

                if (cbTables.SelectedIndex == 6) //Sales
                    dgvCurrentTable.DataSource = db.Sales.ToList();

                if (cbTables.SelectedIndex == 7) //Buyers
                    dgvCurrentTable.DataSource = db.Buyers.ToList(); 

                if (cbTables.SelectedIndex == 8) //Basket
                    dgvCurrentTable.DataSource = db.Basket.ToList(); 

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void bSaveChanges_Click(object sender, EventArgs e)
        {
            try { 
                db.SaveChanges();
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void bFindBook_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbBookName.Checked)
                    dgvCurrentTable.DataSource = db.Books.Where(x=>x.Name == tbFind.Text).ToList();

                if(rbAuthor.Checked)
                    dgvCurrentTable.DataSource = db.Books.Where(x => x.Authors.Name == tbFind.Text).ToList();

                if(rbGenre.Checked)
                    dgvCurrentTable.DataSource = db.Books.Where(x => x.BooksToGenres.Any(y=>y.Genres.Name==tbFind.Text)).ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bfindMinYear_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCurrentTable.DataSource = db.Books.Where(x => x.Year >= nudMinYear.Value).ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bFindByDate_Click(object sender, EventArgs e)
        {
            try
            { 
                if (cbQuery.SelectedItem == null)
                    throw new Exception("Please select query and try again.");

                DateTime date = DateTime.Now;

                if (rb7days.Checked)
                    date = DateTime.Now.Date.AddDays(-7);

                if (rb30days.Checked)
                    date = DateTime.Now.Date.AddDays(-30);

                if (rb365days.Checked)
                    date = DateTime.Now.Date.AddDays(-365);


                if (cbQuery.SelectedIndex == 0) //Top5 BestSeller
                    dgvCurrentTable.DataSource = db.Books.Where(x => x.Sales.Any(y => y.Date >= date))
                        .Select(x => new { Name = x.Name, CountSales = x.Sales.Count })
                        .OrderByDescending(x => x.CountSales)
                        .Take(5)
                        .ToList();

                if (cbQuery.SelectedIndex == 1) //Top5 popular Authors
                    dgvCurrentTable.DataSource = db.Sales.Where(x => x.Date >= date)
                        .Select(x => x.Books.Authors)
                        .GroupBy(x => x.Name)
                        .OrderByDescending(x => x.Count())
                        .Select(x => new { Name = x.Key, Count = x.Count() })
                        .Take(5)
                        .ToList();

                if (cbQuery.SelectedIndex == 2) //Top5 popular Genre
                    dgvCurrentTable.DataSource = db.Sales.Where(x => x.Date >= date)
                        .SelectMany(x => x.Books.BooksToGenres)
                        .Select(x => x.Genres)
                        .GroupBy(x => x.Name)
                        .OrderByDescending(x => x.Count())
                        .Select(x => new { Name = x.Key, Count = x.Count() })
                        .Take(5)
                        .ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbAddTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAddTo.SelectedIndex == 0) //Authors
            {
                new AddAuthor(db).ShowDialog();
                dgvCurrentTable.DataSource = db.Authors.ToList();
            }
            if (cbAddTo.SelectedIndex == 1) //Books
            {
                new AddBook(db).ShowDialog();
                dgvCurrentTable.DataSource = db.Books.ToList();
            }
            if (cbAddTo.SelectedIndex == 2) //BooksToGenres
            {
                new AddBooksToGenres(db).ShowDialog();
                dgvCurrentTable.DataSource = db.BooksToGenres.ToList();
            }
            if (cbAddTo.SelectedIndex == 3) //Genres
            {
                new AddGenres(db).ShowDialog();
                dgvCurrentTable.DataSource = db.Genres.ToList();
            }

            if (cbAddTo.SelectedIndex == 4) //Promotions
            {
                new AddPromotion(db).ShowDialog();
                dgvCurrentTable.DataSource = db.Promotions.ToList();
            }

            if (cbAddTo.SelectedIndex == 5) //Publishing
            {
                new AddPublishing(db).ShowDialog();
                dgvCurrentTable.DataSource = db.Publishing.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
