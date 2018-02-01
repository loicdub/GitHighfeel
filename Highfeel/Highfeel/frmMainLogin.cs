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
    public partial class frmMainLogin : Form
    {
        public frmMainLogin()
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
    }
}
