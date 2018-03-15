using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Highfeel
{
    public partial class frmLogin : Form
    {
        ConnectDB dbc = new ConnectDB();
        private string _userConnected;

        public string UserConnected { get => _userConnected; set => _userConnected = value; }

        public frmLogin()
        {
            InitializeComponent();
            securityTextbox();
        }

        private void securityTextbox()
        {
            if (tbxUsername.Text.Length > 0 && tbxPassword.Text.Length > 0)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        // Vérifie les données de connection utilisateur
        public bool loginOK()
        {
            bool loginIsOk = false;
            // Si la requête SQL retourne true, le login est OK
            if (dbc.loginsql(tbxUsername.Text, tbxPassword.Text))
            {
                loginIsOk = true;
                this.UserConnected = tbxUsername.Text;
            }
            // Sinon
            else
            {
                loginIsOk = false;
            }

            return loginIsOk;
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            securityTextbox();
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            securityTextbox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginOK())
            {
            }
            else
            {
                MessageBox.Show("Le mot de passe est erroné !", "Information", MessageBoxButtons.OK);
            }
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loginOK())
            {
                Application.Exit();
            }
        }
    }
}
