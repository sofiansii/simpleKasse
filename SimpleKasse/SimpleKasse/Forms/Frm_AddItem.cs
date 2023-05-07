using SimpleKasseLogic.Classes;
using SimpleKasseLogic.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKasse.Forms
{
    public partial class Frm_AddItem : Form
    {
        public Article CartArticle;
        public List<Article> cart;
        public Frm_AddItem(List<Article> cart)
        {
            InitializeComponent();
            this.cart = cart;
        }


        private void UpdateTotal(double price)
        {
            lbl_Total.Visible = true;
            lbl_Total.Text = $"Gesamtbetrag : {price * (double)txt_Quantity.Value}";
        }

       

        private void txt_Quantity_ValueChanged(object sender, EventArgs e)
        {
            var article = ArticleDAO.getArticle(txt_name.Text);
            UpdateTotal(article.Price);

        }

        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            var article = ArticleDAO.getArticle(txt_name.Text);
            if (article == null || article.Quantity == 0 || (cart.Contains(article) && article.Quantity - cart.Find(x=> x.Name == article.Name).Quantity == 0 ))
            {
                txt_name.BorderColor = Color.Red;
                txt_name.FocusedState.BorderColor = Color.Red;
                txt_Quantity.Visible = false;
                lbl_quantity.Visible = false;
                lbl_Total.Visible = false;
            }
            else
            {
                txt_name.BorderColor = Color.Green;
                txt_name.FocusedState.BorderColor = Color.Green;
                txt_Quantity.Visible = true;
                lbl_quantity.Visible = true;
                txt_Quantity.Minimum = 1;
                Article alreadyInCart = cart.Find(x => x.Name == article.Name);
                txt_Quantity.Maximum = article.Quantity - (alreadyInCart == null ? 0 : alreadyInCart.Quantity);
                UpdateTotal(article.Price);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CartArticle = ArticleDAO.getArticle(txt_name.Text);
            CartArticle.Quantity = (int) txt_Quantity.Value;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
