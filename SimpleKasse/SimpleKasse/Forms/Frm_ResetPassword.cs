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
    public partial class Frm_ResetPassword : Form
    {
        private User user;
        public Frm_ResetPassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            user.Password = txt_Password.Text;
            UserDAO.ResetPassword(user);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
