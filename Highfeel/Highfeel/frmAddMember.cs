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
    public partial class frmAddMember : Form
    {
        ConnectDB dbc = new ConnectDB();
        private string _newMember;
        public string NewMember { get => _newMember; set => _newMember = value; }

        public frmAddMember()
        {
            InitializeComponent();
            ShowMembers();
        }


        public void ShowMembers()
        {
            for (int i = 0; i < dbc.getAllUsers().Count; i++)
            {
                cbxMembers.Items.Add(dbc.getAllUsers()[i].ToString());
            }
            cbxMembers.SelectedIndex = 0;
        }

        private void cbxMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NewMember = cbxMembers.SelectedItem.ToString();
        }
    }
}
