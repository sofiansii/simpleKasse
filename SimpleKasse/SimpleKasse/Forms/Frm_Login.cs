using SimpleKasseLogic.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SimpleKasse.Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (!UserDAO.AdminExists())
            {
                Hide();
                var f = new Frm_CreateAdminAccount();
                f.ShowDialog();
                Show();
            }

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = UserDAO.Login(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Falscher Benutzername oder falsches Passwort");
            }else
            {
                UserDAO.LastLog(user);
                Hide();
                Form f;
                if (user.Role == "admin")
                    f = new Frm_Main();
                else f = new Frm_MainKassier();
                f.ShowDialog();
                this.Close();

            }
        }

        
    }
}
