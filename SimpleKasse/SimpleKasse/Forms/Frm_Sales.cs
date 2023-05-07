using SimpleKasse.Controls;
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
    public partial class Frm_Sales : Form
    {
        public Frm_Sales()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            pnl_Sales.Controls.Clear();
            var sales = UserDAO.CurrentUser.Role != "admin"  ?  SaleDAO.GetSales(UserDAO.CurrentUser.UserName ) : SaleDAO.GetSales();
            foreach(var s in sales)
            {
                pnl_Sales.Controls.Add(new C_Sale(s));
            }
        }

        private void btn_newSale_Click(object sender, EventArgs e)
        {
            var f = new Frm_NewSale(null);
            f.ShowDialog();
            load();
        }
    }
}
