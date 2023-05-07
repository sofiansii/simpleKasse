using SimpleKasse.Forms;
using SimpleKasseLogic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleKasse.Controls
{
    public partial class C_CartArticle : UserControl
    {
        public Article article;
        public C_CartArticle(Article article,bool canRemove = true)
        {
            InitializeComponent();
            lbl_Name.Text = article.Name;
            lbl_Quantity.Text = article.Quantity.ToString();
            lbl_Price.Text = (article.Quantity * article.Price).ToString();
            this.article = article;
            this.Dock = DockStyle.Top;
            if (!canRemove) btn_remove.Visible = false;
        }
        public void UpdateQuantity(int newQuantity) 
        {
            lbl_Quantity.Text = newQuantity.ToString();
            article.Quantity = newQuantity;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            ((Frm_NewSale)ParentForm).RemoveItem(article.Name);
        }
    }
}
