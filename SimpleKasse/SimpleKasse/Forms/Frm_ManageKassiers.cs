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
    public partial class Frm_ManageKassiers : Form
    {
        public Frm_ManageKassiers()
        {
            InitializeComponent();
            load();

        }
        public void load()
        {
            pnl_Kassiers.Controls.Clear();
            var kassiers = UserDAO.GetKassiers();
            foreach(User kassier in kassiers)
            {
                pnl_Kassiers.Controls.Add(new C_Kassier(kassier));
            }
        }

        private void btn_newKassier_Click(object sender, EventArgs e)
        {
            var f = new Frm_AddKassier();
            f.ShowDialog();
            load();

        }
    }
}
