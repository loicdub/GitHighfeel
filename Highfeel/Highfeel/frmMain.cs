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
            List<PictureBox> pbx = new List<PictureBox>();
            dateTimePicker1.MaxDate = DateTime.Now;

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

            lblConnectedUser.Text = "Bonjour " + login.UserConnected + ".";
        }

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
            lbClan.DataSource = dbc.getAllClanByUser(dbc.getUserIdByUsername(login.UserConnected).ToString());
            lbClan.DisplayMember = "clanName";
            lbClan.ValueMember = "clanId";

            checkAdmin();
        }

        private void checkAdmin()
        {
            try
            {
                if (login.UserConnected == dbc.getClanAdmin(lbClan.SelectedValue.ToString()))
                {
                    btnAddMember.Enabled = true;
                }
                else
                {
                    btnAddMember.Enabled = false;
                }
            }
            catch (Exception) { }
        }

        private void UpdateMemberList()
        {
            try
            {
                for (int i = 0; i < dbc.getAllUsersByClan(lbClan.SelectedValue.ToString()).Count; i++)
                {
                    if (tbxMembers.Text == "")
                    {
                        tbxMembers.Text += dbc.getAllUsersByClan(lbClan.SelectedValue.ToString())[i];
                    }
                    else
                    {
                        tbxMembers.Text += ", " + dbc.getAllUsersByClan(lbClan.SelectedValue.ToString())[i];
                    }
                }
            }
            catch (Exception)
            {
                tbxMembers.Text = "(Aucun membre)";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateClanList();
            UpdateMemberList();
        }

        private void lbClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxMembers.Text = "";
            UpdateMemberList();
            try { checkAdmin(); } catch (Exception) { }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember addMember = new frmAddMember();
            if (addMember.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dbc.addMember(lbClan.SelectedValue.ToString(), addMember.NewMember);
                    tbxMembers.Text = "";
                    UpdateMemberList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ce membre est déjà dans ce clan !");
                }
            }
        }

        private void pbx_Click(object sender, EventArgs e)
        {
            frmComment comment = new frmComment();

            if (comment.ShowDialog() == DialogResult.OK)
            {
                string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string currentClan = lbClan.SelectedValue.ToString();

                dbc.sendMood(((PictureBox)sender).Tag.ToString(), comment.Comment, login.UserConnected, selectedDate, currentClan);
            }
        }
    }
}
