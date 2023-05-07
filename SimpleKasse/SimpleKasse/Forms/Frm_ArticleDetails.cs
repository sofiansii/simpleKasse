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
    public partial class Frm_ArticleDetails : Form
    {
        Article _article;
        public Frm_ArticleDetails(Article article)
        {
            InitializeComponent();
            _article = article;
            load();
            if (UserDAO.CurrentUser.Role != "admin")
                btn_edit.Visible = false;
        }
        private void load()
        {
            lbl_name.Text = _article.Name;
            lbl_price.Text = _article.Price.ToString();
            lbl_Quantity.Text = _article.Quantity.ToString();
            lbl_description.Text = _article.Description;
            lbl_sold.Text = ArticleDAO.QuantitySold(_article.Name).ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var f = new Frm_ModifyArticle(_article);
            f.ShowDialog();
            _article = ArticleDAO.getArticle(_article.Name);
            load();
        }
    }
}
