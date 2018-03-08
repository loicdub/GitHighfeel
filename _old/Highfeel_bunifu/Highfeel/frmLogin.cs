using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighFeel
{
    public partial class frmLogin : Form
    {
        // Initialise une instance de connexion à la base de donnée
        ConnectDB dbc = new ConnectDB();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {
            if (tbxID.Text.Length > 0 && tbxPWD.Text.Length > 0)
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }

        private void tbxPWD_TextChanged(object sender, EventArgs e)
        {
            if (tbxID.Text.Length > 0 && tbxPWD.Text.Length > 0)
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }

        // Vérifie les données de connection administrateur
        public bool loginAdminOK()
        {
            bool loginIsOk = false;
            // Si la requête SQL retourne true, le login est OK
            if (dbc.loginsql(tbxID.Text, tbxPWD.Text))
            {
                loginIsOk = true;
            }
            // Sinon
            else
            {
                loginIsOk = false;
            }

            return loginIsOk;
        }

        // Vérifie les données de connection utilisateur
        public bool loginUserOK()
        {
            bool loginIsOk = false;
            // Si la requête SQL retourne true, le login est OK
            if (dbc.loginsql(tbxID.Text, tbxPWD.Text))
            {
                loginIsOk = true;
            }
            // Sinon
            else
            {
                loginIsOk = false;
            }

            return loginIsOk;
        }
    }
}
