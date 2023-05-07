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
    public partial class Frm_CreateAdminAccount : Form
    {
        public Frm_CreateAdminAccount()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var user = new User(txt_UserName.Text,txt_Password.Text,DateOnly.FromDateTime(DateTime.Now).ToString(),"admin");
            var res = UserDAO.AddUser(user);
            if (res)
            {
                MessageBox.Show("Admin erfolgreich erstellt");
                Close();
            }else
            {
                MessageBox.Show("Es ist ein Fehler beim Erstellen des Benutzers aufgetreten");
            }
        }
    }
}
