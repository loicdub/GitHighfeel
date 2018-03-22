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
    public partial class frmClan : Form
    {
        // Initialise une instance de connexion à la base de donnée
        ConnectDB dbc = new ConnectDB();
        //frmLogin login = new frmLogin();
        private string _connectedUser;

        public frmClan(string connectedUser)
        {
            InitializeComponent();
            this._connectedUser = connectedUser;
        }

        public void createClan() {
            string clanName = tbxClanName.Text;

            dbc.createClan(clanName, dbc.getUserIdByUsername(_connectedUser));
        }

        private void tbxClanName_TextChanged(object sender, EventArgs e)
        {
            if (tbxClanName.Text.Length> 0)
            {
                btnCreateClan.Enabled = true;
            }
            else
            {
                btnCreateClan.Enabled = false;
            }
        }
    }
}
