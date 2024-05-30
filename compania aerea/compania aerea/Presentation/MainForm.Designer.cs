namespace Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDesktopHeader = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPacients = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelMenuHeader = new System.Windows.Forms.Panel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.linkProfile = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.btnSideMenu = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.PanelClientArea.SuspendLayout();
            this.panelDesktopHeader.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelMenuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenu)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelClientArea
            // 
            this.PanelClientArea.Controls.Add(this.panelDesktop);
            this.PanelClientArea.Controls.Add(this.panelDesktopHeader);
            this.PanelClientArea.Controls.Add(this.panelSideMenu);
            this.PanelClientArea.Controls.Add(this.panelTitleBar);
            this.PanelClientArea.Size = new System.Drawing.Size(1198, 598);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(998, 528);
            this.panelDesktop.TabIndex = 7;
            // 
            // panelDesktopHeader
            // 
            this.panelDesktopHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDesktopHeader.Controls.Add(this.lblCaption);
            this.panelDesktopHeader.Controls.Add(this.btnChildFormClose);
            this.panelDesktopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopHeader.Location = new System.Drawing.Point(200, 40);
            this.panelDesktopHeader.Name = "panelDesktopHeader";
            this.panelDesktopHeader.Size = new System.Drawing.Size(998, 30);
            this.panelDesktopHeader.TabIndex = 6;
            // 
            // lblCaption
            // 
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaption.Location = new System.Drawing.Point(30, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(424, 30);
            this.lblCaption.TabIndex = 18;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChildFormClose
            // 
            this.btnChildFormClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChildFormClose.FlatAppearance.BorderSize = 0;
            this.btnChildFormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnChildFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormClose.Image = ((System.Drawing.Image)(resources.GetObject("btnChildFormClose.Image")));
            this.btnChildFormClose.Location = new System.Drawing.Point(0, 0);
            this.btnChildFormClose.Name = "btnChildFormClose";
            this.btnChildFormClose.Size = new System.Drawing.Size(30, 30);
            this.btnChildFormClose.TabIndex = 19;
            this.btnChildFormClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChildFormClose.UseVisualStyleBackColor = true;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnReports);
            this.panelSideMenu.Controls.Add(this.btnCalendar);
            this.panelSideMenu.Controls.Add(this.btnHistory);
            this.panelSideMenu.Controls.Add(this.btnPacients);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.panelMenuHeader);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 40);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 558);
            this.panelSideMenu.TabIndex = 5;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogout.Image = global::Presentation.Properties.Resources.bloquear;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(39, 269);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(143, 45);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "  Cerrar sesión";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.DarkGray;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(-2, 440);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(230, 45);
            this.btnReports.TabIndex = 24;
            this.btnReports.Text = "Vuelos";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(-5, 392);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(230, 45);
            this.btnCalendar.TabIndex = 23;
            this.btnCalendar.Text = "Tripulacion";
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.DarkGray;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(0, 343);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(230, 45);
            this.btnHistory.TabIndex = 22;
            this.btnHistory.Text = "Aviones";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPacients
            // 
            this.btnPacients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacients.FlatAppearance.BorderSize = 0;
            this.btnPacients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacients.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPacients.Image = global::Presentation.Properties.Resources.personas;
            this.btnPacients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacients.Location = new System.Drawing.Point(39, 204);
            this.btnPacients.Margin = new System.Windows.Forms.Padding(2);
            this.btnPacients.Name = "btnPacients";
            this.btnPacients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPacients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPacients.Size = new System.Drawing.Size(143, 45);
            this.btnPacients.TabIndex = 21;
            this.btnPacients.Text = "Socios";
            this.btnPacients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacients.UseVisualStyleBackColor = true;
            this.btnPacients.Click += new System.EventHandler(this.btnPacients_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUsers.Image = global::Presentation.Properties.Resources.agregar_usuario;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(39, 145);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(142, 45);
            this.btnUsers.TabIndex = 20;
            this.btnUsers.Text = "Clientes";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelMenuHeader
            // 
            this.panelMenuHeader.BackColor = System.Drawing.Color.Black;
            this.panelMenuHeader.Controls.Add(this.lblLastName);
            this.panelMenuHeader.Controls.Add(this.linkProfile);
            this.panelMenuHeader.Controls.Add(this.pictureBoxPhoto);
            this.panelMenuHeader.Controls.Add(this.btnSideMenu);
            this.panelMenuHeader.Controls.Add(this.lblPosition);
            this.panelMenuHeader.Controls.Add(this.lblName);
            this.panelMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHeader.Name = "panelMenuHeader";
            this.panelMenuHeader.Size = new System.Drawing.Size(200, 115);
            this.panelMenuHeader.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLastName.Location = new System.Drawing.Point(72, 36);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 17);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Apellido";
            // 
            // linkProfile
            // 
            this.linkProfile.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkProfile.AutoSize = true;
            this.linkProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkProfile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.linkProfile.Location = new System.Drawing.Point(6, 78);
            this.linkProfile.Name = "linkProfile";
            this.linkProfile.Size = new System.Drawing.Size(40, 17);
            this.linkProfile.TabIndex = 16;
            this.linkProfile.TabStop = true;
            this.linkProfile.Text = "Perfil";
            this.linkProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProfile_LinkClicked);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = global::Presentation.Properties.Resources.perfilorange;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(6, 11);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 13;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPhoto_Paint);
            // 
            // btnSideMenu
            // 
            this.btnSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSideMenu.Image")));
            this.btnSideMenu.Location = new System.Drawing.Point(158, 6);
            this.btnSideMenu.Name = "btnSideMenu";
            this.btnSideMenu.Size = new System.Drawing.Size(32, 32);
            this.btnSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSideMenu.TabIndex = 12;
            this.btnSideMenu.TabStop = false;
            this.btnSideMenu.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPosition.Location = new System.Drawing.Point(72, 52);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 15;
            this.lblPosition.Text = "Puesto";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(72, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Nombre";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OrangeRed;
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.pictureBox2);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1198, 40);
            this.panelTitleBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Air bnb";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentation.Properties.Resources.aire_bnb;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1093, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Location = new System.Drawing.Point(1128, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "M";
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1163, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelClientArea.ResumeLayout(false);
            this.panelDesktopHeader.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMenuHeader.ResumeLayout(false);
            this.panelMenuHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideMenu)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelDesktopHeader;
        internal System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.Panel panelSideMenu;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Button btnReports;
        internal System.Windows.Forms.Button btnCalendar;
        internal System.Windows.Forms.Button btnHistory;
        internal System.Windows.Forms.Button btnPacients;
        internal System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelMenuHeader;
        internal System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.LinkLabel linkProfile;
        internal System.Windows.Forms.PictureBox pictureBoxPhoto;
        internal System.Windows.Forms.PictureBox btnSideMenu;
        internal System.Windows.Forms.Label lblPosition;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelTitleBar;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}

