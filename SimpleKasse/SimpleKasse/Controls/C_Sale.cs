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
    public partial class C_Sale : UserControl
    {
        Sale sale;
        public C_Sale(Sale sale)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            lbl_date.Text = sale.date;
            lbl_ItemsInCart.Text = sale.cart.Count().ToString();
            lbl_TotalPrice.Text = sale.cart.Sum(x => x.Quantity * x.Price).ToString();
            this.sale = sale;
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            var f = new Frm_NewSale(sale);
            f.ShowDialog();
        }
    }
}
