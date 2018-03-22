namespace Highfeel
{
    partial class frmComment
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
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.btnSendComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Écrivez un commentaire (facultatif) :";
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(12, 25);
            this.tbxComment.Multiline = true;
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.Size = new System.Drawing.Size(260, 78);
            this.tbxComment.TabIndex = 1;
            // 
            // btnSendComment
            // 
            this.btnSendComment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSendComment.Location = new System.Drawing.Point(12, 109);
            this.btnSendComment.Name = "btnSendComment";
            this.btnSendComment.Size = new System.Drawing.Size(260, 23);
            this.btnSendComment.TabIndex = 2;
            this.btnSendComment.Text = "Envoyer l\'humeur (anonyme)";
            this.btnSendComment.UseVisualStyleBackColor = true;
            this.btnSendComment.Click += new System.EventHandler(this.btnSendComment_Click);
            // 
            // frmComment
            // 
            this.AcceptButton = this.btnSendComment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.btnSendComment);
            this.Controls.Add(this.tbxComment);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Envoyer un commentaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Button btnSendComment;
    }
}