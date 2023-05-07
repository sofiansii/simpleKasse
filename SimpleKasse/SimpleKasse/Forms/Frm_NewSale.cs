using SimpleKasse.Controls;
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
    public partial class Frm_NewSale : Form
    {
        public Frm_NewSale(Sale sale)
        {
            InitializeComponent();
            if (sale != null)
            {
                btn_CheckOut.Visible = false;
                btn_AddItem.Visible = false;
                cart = sale.cart;
                foreach(var c in sale.cart)
                    pnl_Items.Controls.Add(new C_CartArticle(c,false));
                UpdateTotal();
                btn_Cancel.Text = "schließen";
            }
        }
        List<Article> cart = new List<Article>();

        private void UpdateTotal()
        {
            lbl_Total.Text = $"Gesamtbetrag : {cart.Sum(x=>x.Quantity * x.Price)}";
        }

        public void RemoveItem(string name)
        {
            foreach(C_CartArticle c in pnl_Items.Controls)
                if (c.article.Name == name)
                    pnl_Items.Controls.Remove(c);
            cart.RemoveAll(x => x.Name == name);
            UpdateTotal();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_AddItem(cart);
            f.ShowDialog();
            if (f.CartArticle == null) return;
            if (!cart.Contains(f.CartArticle))
            {
                cart.Add(f.CartArticle);
                pnl_Items.Controls.Add(new C_CartArticle(f.CartArticle));
            }else
            {
                var updatedArticle = cart.Find(x => x.Name == f.CartArticle.Name);
                updatedArticle.Quantity += f.CartArticle.Quantity;
                foreach(C_CartArticle pnl_article in pnl_Items.Controls)
                    if (pnl_article.article.Name == f.CartArticle.Name)
                    {
                        pnl_Items.Controls.Remove(pnl_article);
                        pnl_Items.Controls.Add(new C_CartArticle(updatedArticle));
                        break;
                    }
            }
            UpdateTotal();

        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            SaleDAO.AddSale(cart);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
