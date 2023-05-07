using SimpleKasse.Forms;
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

namespace SimpleKasse.Controls
{
    public partial class C_Kassier : UserControl
    {
        User user;
        public C_Kassier(User user)
        {
            InitializeComponent();
            this.Dock= DockStyle.Top;
            lbl_Name.Text = user.UserName;
            lbl_LastLog.Text = user.lastlog;
            this.user = user;
        }

        private void btn_resetPass_Click(object sender, EventArgs e)
        {
            var f = new Frm_ResetPassword(user);
            f.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (UserDAO.DeleteUser(user.UserName))
            {
                ((Frm_ManageKassiers)this.ParentForm).load();
            }
        }
    }
}
