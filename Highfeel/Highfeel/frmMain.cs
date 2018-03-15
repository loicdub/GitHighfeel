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
        frmLogin login = new frmLogin();
        ConnectDB dbc = new ConnectDB();
        public frmMain()
        {
            InitializeComponent();
            login.ShowDialog(this);
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

            lblConnectedUser.Text = "Bonsoir, je suis Bob Lennon et vous êtes " + login.UserConnected + ".";
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

        private void btnCreateClan_Click(object sender, EventArgs e)
        {
            frmClan clan = new frmClan(login.UserConnected);
            if (clan.ShowDialog() == DialogResult.OK)
            {
                clan.createClan();
                UpdateClanList();
            }
        }

        private void UpdateClanList()
        {
            lbClan.DataSource = dbc.getAllClanByUser(dbc.getUserIdByUsername(login.UserConnected));
            lbClan.DisplayMember = "clanName";
            lbClan.ValueMember = "clanId";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateClanList();
        }
    }
}
