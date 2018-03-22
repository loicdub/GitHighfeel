namespace Highfeel
{
    partial class frmAddMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxMembers = new System.Windows.Forms.ComboBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxMembers
            // 
            this.cbxMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMembers.FormattingEnabled = true;
            this.cbxMembers.Location = new System.Drawing.Point(12, 12);
            this.cbxMembers.Name = "cbxMembers";
            this.cbxMembers.Size = new System.Drawing.Size(250, 21);
            this.cbxMembers.TabIndex = 0;
            this.cbxMembers.SelectedIndexChanged += new System.EventHandler(this.cbxMembers_SelectedIndexChanged);
            // 
            // btnAddMember
            // 
            this.btnAddMember.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddMember.Location = new System.Drawing.Point(12, 39);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(250, 23);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Ajouter le membre";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // frmAddMember
            // 
            this.AcceptButton = this.btnAddMember;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 74);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cbxMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMember";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un membre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMembers;
        private System.Windows.Forms.Button btnAddMember;
    }
}