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
    public partial class Frm_ModifyArticle : Form
    {
        Article _article;
        public Frm_ModifyArticle(Article article)
        {
            InitializeComponent();
            if (article == null)
            {
                btn_Action.Text = "hinzufügen";
            }else
            {
                btn_Action.Text = "bearbeiten";
                txt_name.Enabled = false;
                txt_name.Text = article.Name;
                txt_price.Value = (decimal) article.Price;
                txt_quantity.Value = article.Quantity;
                txt_description.Text = article.Description;
                _article = article;
            }
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (_article == null)
            {
                ArticleDAO.AddArticle(new Article(txt_name.Text, txt_description.Text, (int)txt_quantity.Value,(double) txt_price.Value));
                this.Close();
            }
            else
            {
                ArticleDAO.UpdateArticle(new Article(txt_name.Text, txt_description.Text, (int)txt_quantity.Value, (double)txt_price.Value));
                this.Close();
            }
        }
    }
}
