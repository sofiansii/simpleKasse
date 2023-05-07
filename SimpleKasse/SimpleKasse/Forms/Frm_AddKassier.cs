using SimpleKasseLogic.database;
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

namespace SimpleKasse.Forms
{
    public partial class Frm_AddKassier : Form
    {
        public Frm_AddKassier()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var res = UserDAO.AddUser(new User(txt_UserName.Text,txt_Password.Text,"","kassier"));
            if (!res)
                MessageBox.Show("There Was an Error");
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
