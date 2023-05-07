using SimpleKasse.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleKasseLogic.database;
using SimpleKasseLogic.Classes;
namespace SimpleKasse.Forms
{
    public partial class Frm_ManageArticles : Form
    {
        public Frm_ManageArticles()
        {
           
            InitializeComponent();
            if (UserDAO.CurrentUser.Role != "admin")
                btn_newArticle.Visible = false;
            load();
            
        }
        public void load()
        {
            pnl_Articles.Controls.Clear();
            var articles = ArticleDAO.GetArticles();
            foreach (Article article in articles)
            {
                pnl_Articles.Controls.Add(new C_Article(article));
            }
        }

        private void btn_newArticle_Click(object sender, EventArgs e)
        {
            var f = new Frm_ModifyArticle(null);
            f.ShowDialog();
            load();
        }
    }
}
