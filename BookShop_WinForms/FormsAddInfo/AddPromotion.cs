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
    public partial class AddPromotion : Form
    {
        private BookShopEntities2 db;
        public AddPromotion(BookShopEntities2 Db)
        {
            InitializeComponent();
            db= Db;
        }

        private void AddPromotion_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try {
                db.Promotions.Add(new Promotions {Name=tbPromotionName.Text,DiscountPercent= (int)nudDiscountPercent.Value});
                db.SaveChanges();
                tbPromotionName.Text= string.Empty;
                nudDiscountPercent.Value = 0;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
