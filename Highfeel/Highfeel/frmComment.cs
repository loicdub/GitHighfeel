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
    public partial class frmComment : Form
    {
        private string _comment;
        public string Comment { get => _comment; set => _comment = value; }

        public frmComment()
        {
            InitializeComponent();
        }

        private void btnSendComment_Click(object sender, EventArgs e)
        {
            this.Comment = tbxComment.Text;
        }
    }
}
