namespace Highfeel
{
    partial class frmClan
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxClanName = new System.Windows.Forms.TextBox();
            this.btnCreateClan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez le nom du clan :";
            // 
            // tbxClanName
            // 
            this.tbxClanName.Location = new System.Drawing.Point(12, 25);
            this.tbxClanName.Name = "tbxClanName";
            this.tbxClanName.Size = new System.Drawing.Size(115, 20);
            this.tbxClanName.TabIndex = 1;
            this.tbxClanName.TextChanged += new System.EventHandler(this.tbxClanName_TextChanged);
            // 
            // btnCreateClan
            // 
            this.btnCreateClan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateClan.Enabled = false;
            this.btnCreateClan.Location = new System.Drawing.Point(12, 51);
            this.btnCreateClan.Name = "btnCreateClan";
            this.btnCreateClan.Size = new System.Drawing.Size(113, 23);
            this.btnCreateClan.TabIndex = 2;
            this.btnCreateClan.Text = "Créer";
            this.btnCreateClan.UseVisualStyleBackColor = true;
            // 
            // frmClan
            // 
            this.AcceptButton = this.btnCreateClan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 82);
            this.Controls.Add(this.btnCreateClan);
            this.Controls.Add(this.tbxClanName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer un clan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxClanName;
        private System.Windows.Forms.Button btnCreateClan;
    }
}