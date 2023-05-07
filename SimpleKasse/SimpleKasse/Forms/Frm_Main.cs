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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            Form f = new Frm_ManageKassiers();
            f.TopLevel = false;
            pnl_Main.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ManageArticles_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls[0].Hide();
            pnl_Main.Controls.RemoveAt(0);

            var f = new Frm_ManageArticles();
            f.TopLevel = false;
            pnl_Main.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void btn_manageKassiers_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls[0].Hide();
            pnl_Main.Controls.RemoveAt(0);

            var f = new Frm_ManageKassiers();
            f.TopLevel = false;
            pnl_Main.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls[0].Hide();
            pnl_Main.Controls.RemoveAt(0);

            var f = new Frm_Sales();
            f.TopLevel = false;
            pnl_Main.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Hide();
            var f = new Frm_Login();
            f.ShowDialog();
            Close();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            var f = new Frm_ResetPassword(UserDAO.CurrentUser);
            f.ShowDialog();
        }
    }
}
