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
        public frmLogin()
        {
            InitializeComponent();
        }

        // Vérifie les données de connection utilisateur
        public bool loginOK()
        {
            bool loginIsOk = false;
            // Si la requête SQL retourne true, le login est OK
            if (dbc.loginsql(tbxUsername.Text, tbxPassword.Text))
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
