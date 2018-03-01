namespace Highfeel
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
<<<<<<< HEAD
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
=======
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.btn = new ns1.BunifuFlatButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCloseButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn2 = new ns1.BunifuFlatButton();
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseButton)).BeginInit();
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 527);
            this.panel1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
<<<<<<< HEAD
            this.pnlHeader.Controls.Add(this.pictureBox3);
=======
            this.pnlHeader.Controls.Add(this.pbCloseButton);
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(859, 50);
            this.pnlHeader.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(188, 35);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Sliding Menu - Bunifu UI";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
<<<<<<< HEAD
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 51);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(194, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
=======
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn
            // 
            this.btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn.BorderRadius = 0;
            this.btn.ButtonText = "        Bouton 1";
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.DisabledColor = System.Drawing.Color.Gray;
            this.btn.Iconcolor = System.Drawing.Color.Transparent;
            this.btn.Iconimage = null;
            this.btn.Iconimage_right = null;
            this.btn.Iconimage_right_Selected = null;
            this.btn.Iconimage_Selected = null;
            this.btn.IconMarginLeft = 0;
            this.btn.IconMarginRight = 0;
            this.btn.IconRightVisible = true;
            this.btn.IconRightZoom = 0D;
            this.btn.IconVisible = true;
            this.btn.IconZoom = 90D;
            this.btn.IsTab = false;
            this.btn.Location = new System.Drawing.Point(0, 51);
            this.btn.Name = "btn";
            this.btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn.selected = false;
            this.btn.Size = new System.Drawing.Size(200, 48);
            this.btn.TabIndex = 2;
            this.btn.Text = "        Bouton 1";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Textcolor = System.Drawing.Color.Silver;
            this.btn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuImageButton1.Image = global::Highfeel.Properties.Resources.menu;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(155, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Highfeel.Properties.Resources.highfeel_icon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
<<<<<<< HEAD
=======
            // pbCloseButton
            // 
            this.pbCloseButton.Image = global::Highfeel.Properties.Resources.close;
            this.pbCloseButton.Location = new System.Drawing.Point(812, 9);
            this.pbCloseButton.Name = "pbCloseButton";
            this.pbCloseButton.Size = new System.Drawing.Size(35, 35);
            this.pbCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseButton.TabIndex = 2;
            this.pbCloseButton.TabStop = false;
            this.pbCloseButton.Click += new System.EventHandler(this.pbCloseButton_Click);
            // 
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
<<<<<<< HEAD
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Highfeel.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(812, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
=======
            // btn2
            // 
            this.btn2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.BorderRadius = 0;
            this.btn2.ButtonText = "        Bouton 2";
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.DisabledColor = System.Drawing.Color.Gray;
            this.btn2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn2.Iconimage = null;
            this.btn2.Iconimage_right = null;
            this.btn2.Iconimage_right_Selected = null;
            this.btn2.Iconimage_Selected = null;
            this.btn2.IconMarginLeft = 0;
            this.btn2.IconMarginRight = 0;
            this.btn2.IconRightVisible = true;
            this.btn2.IconRightZoom = 0D;
            this.btn2.IconVisible = true;
            this.btn2.IconZoom = 90D;
            this.btn2.IsTab = false;
            this.btn2.Location = new System.Drawing.Point(0, 105);
            this.btn2.Name = "btn2";
            this.btn2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn2.selected = false;
            this.btn2.Size = new System.Drawing.Size(200, 48);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "        Bouton 2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Textcolor = System.Drawing.Color.Silver;
            this.btn2.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(859, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
<<<<<<< HEAD
=======
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseButton)).EndInit();
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuFlatButton btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuDragControl bunifuDragControl1;
=======
        private System.Windows.Forms.PictureBox pbCloseButton;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuFlatButton btn2;
>>>>>>> aff650f26e390ab38a6948f3f85a863d4d18f025
    }
}

