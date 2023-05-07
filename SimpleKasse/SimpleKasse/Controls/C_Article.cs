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
    public partial class C_Article : UserControl
    {
        Article _article;
        public C_Article(Article article)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            lbl_Name.Text = article.Name;
            lbl_Quantity.Text = article.Quantity.ToString();
            _article = article;
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            var f = new Frm_ArticleDetails(_article);
            f.ShowDialog();
            ((Frm_ManageArticles)this.ParentForm).load();
        }
    }
}
