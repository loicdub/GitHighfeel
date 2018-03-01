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
    public partial class frmMain : Form
    {
        ConnectDB dbc = new ConnectDB();

        public frmMain()
        {
            InitializeComponent();
        }

        private void pbCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes application
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //connexion = new frmLogin();
        }
    }
}
