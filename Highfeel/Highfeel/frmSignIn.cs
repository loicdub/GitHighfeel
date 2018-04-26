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
    public partial class frmSignIn : Form
    {
        ConnectDB dbc = new ConnectDB();

        public frmSignIn()
        {
            InitializeComponent();
        }

        #region secure button
        private void securityTextbox()
        {
            if (tbxUsername.Text.Length > 0 && tbxPassword.Text.Length > 0 && tbxPasswordRepeat.Text.Length > 0)
            {
                btnCreateUser.Enabled = true;
            }
            else
            {
                btnCreateUser.Enabled = false;
            }
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            securityTextbox();
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            securityTextbox();
        }

        private void tbxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            securityTextbox();
        }
        #endregion

        public bool checkPasswords() {
            bool passwords;

            if (tbxPassword.Text == tbxPasswordRepeat.Text)
            {
                passwords = true;
            }
            else
            {
                passwords = false;
            }

            return passwords;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (checkPasswords())
            {
                dbc.createUser(tbxUsername.Text, tbxPassword.Text, tbxEmail.Text);
                MessageBox.Show("L'utilisateur a bien été créé.");
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
            }
        }
    }
}
