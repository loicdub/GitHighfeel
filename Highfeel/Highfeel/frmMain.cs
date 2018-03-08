using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// add references
using MySql.Data.MySqlClient;


namespace Highfeel
{
    public partial class frmMain : Form
    {
        ConnectDB dbc = new ConnectDB();
        public frmMain()
        {
            InitializeComponent();
            pbxGrade1.BackgroundImage = Properties.Resources._1;
            pbxGrade2.BackgroundImage = Properties.Resources._2;
            pbxGrade3.BackgroundImage = Properties.Resources._3;
            pbxGrade4.BackgroundImage = Properties.Resources._4;
            pbxGrade5.BackgroundImage = Properties.Resources._5;
            pbxGrade6.BackgroundImage = Properties.Resources._6;
            pbxGrade7.BackgroundImage = Properties.Resources._7;
            pbxGrade8.BackgroundImage = Properties.Resources._8;
            pbxGrade9.BackgroundImage = Properties.Resources._9;
            pbxGrade10.BackgroundImage = Properties.Resources._10;
        }

        private void tsmConnection_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.loginOK())
                {
                    MessageBox.Show("Le mot de passe est correct !", "Information", MessageBoxButtons.OK);
                    tsmConnection.Enabled = false;
                    //deconnexionToolStripMenuItem.Enabled = true;

                }
                else
                    MessageBox.Show("Le mot de passe est erroné !", "Information", MessageBoxButtons.OK);
            }
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region pbxGrade
        private void pbxGrade1_Click(object sender, EventArgs e)
        {
                        
        }

        private void pbxGrade2_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade3_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade4_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade5_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade6_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade7_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade8_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade9_Click(object sender, EventArgs e)
        {

        }

        private void pbxGrade10_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
