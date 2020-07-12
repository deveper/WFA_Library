namespace WFA_Library
{
    partial class ManagementPanelAdmin
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
            this.mtlUserName = new MetroFramework.Controls.MetroLabel();
            this.mtlUserAuthority = new MetroFramework.Controls.MetroLabel();
            this.mtlIp = new MetroFramework.Controls.MetroLabel();
            this.mtlProfile = new MetroFramework.Controls.MetroLabel();
            this.chooseAction = new MetroFramework.Controls.MetroLabel();
            this.cmbAction = new MetroFramework.Controls.MetroComboBox();
            this.grpProcess = new System.Windows.Forms.GroupBox();
            this.pcbUserPhoto = new System.Windows.Forms.PictureBox();
            this.grpProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mtlUserName
            // 
            this.mtlUserName.AutoSize = true;
            this.mtlUserName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlUserName.Location = new System.Drawing.Point(199, 68);
            this.mtlUserName.Name = "mtlUserName";
            this.mtlUserName.Size = new System.Drawing.Size(97, 25);
            this.mtlUserName.TabIndex = 1;
            this.mtlUserName.Text = "User Name";
            this.mtlUserName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtlUserAuthority
            // 
            this.mtlUserAuthority.AutoSize = true;
            this.mtlUserAuthority.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlUserAuthority.Location = new System.Drawing.Point(176, 131);
            this.mtlUserAuthority.Name = "mtlUserAuthority";
            this.mtlUserAuthority.Size = new System.Drawing.Size(120, 25);
            this.mtlUserAuthority.TabIndex = 2;
            this.mtlUserAuthority.Text = "User Authority";
            this.mtlUserAuthority.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtlIp
            // 
            this.mtlIp.AutoSize = true;
            this.mtlIp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlIp.Location = new System.Drawing.Point(215, 100);
            this.mtlIp.Name = "mtlIp";
            this.mtlIp.Size = new System.Drawing.Size(81, 25);
            this.mtlIp.TabIndex = 3;
            this.mtlIp.Text = "Device Ip";
            this.mtlIp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtlProfile
            // 
            this.mtlProfile.AutoSize = true;
            this.mtlProfile.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlProfile.Location = new System.Drawing.Point(172, 165);
            this.mtlProfile.Name = "mtlProfile";
            this.mtlProfile.Size = new System.Drawing.Size(124, 25);
            this.mtlProfile.TabIndex = 4;
            this.mtlProfile.Text = "Profile Settings";
            this.mtlProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // chooseAction
            // 
            this.chooseAction.Location = new System.Drawing.Point(30, 41);
            this.chooseAction.Name = "chooseAction";
            this.chooseAction.Size = new System.Drawing.Size(129, 29);
            this.chooseAction.TabIndex = 9;
            this.chooseAction.Text = "Choose Action:";
            this.chooseAction.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbAction
            // 
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.ItemHeight = 23;
            this.cmbAction.Location = new System.Drawing.Point(137, 38);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(129, 29);
            this.cmbAction.TabIndex = 10;
            this.cmbAction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbAction.UseSelectable = true;
            // 
            // grpProcess
            // 
            this.grpProcess.Controls.Add(this.cmbAction);
            this.grpProcess.Controls.Add(this.chooseAction);
            this.grpProcess.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpProcess.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grpProcess.Location = new System.Drawing.Point(29, 210);
            this.grpProcess.Name = "grpProcess";
            this.grpProcess.Size = new System.Drawing.Size(304, 91);
            this.grpProcess.TabIndex = 11;
            this.grpProcess.TabStop = false;
            this.grpProcess.Text = "Process";
            // 
            // pcbUserPhoto
            // 
            this.pcbUserPhoto.Location = new System.Drawing.Point(47, 63);
            this.pcbUserPhoto.Name = "pcbUserPhoto";
            this.pcbUserPhoto.Size = new System.Drawing.Size(119, 132);
            this.pcbUserPhoto.TabIndex = 0;
            this.pcbUserPhoto.TabStop = false;
            // 
            // ManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 355);
            this.Controls.Add(this.grpProcess);
            this.Controls.Add(this.mtlProfile);
            this.Controls.Add(this.mtlIp);
            this.Controls.Add(this.mtlUserAuthority);
            this.Controls.Add(this.mtlUserName);
            this.Controls.Add(this.pcbUserPhoto);
            this.Name = "ManagementPanel";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Management Panel";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.grpProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbUserPhoto;
        private MetroFramework.Controls.MetroLabel mtlUserName;
        private MetroFramework.Controls.MetroLabel mtlUserAuthority;
        private MetroFramework.Controls.MetroLabel mtlIp;
        private MetroFramework.Controls.MetroLabel mtlProfile;
        private MetroFramework.Controls.MetroLabel chooseAction;
        private MetroFramework.Controls.MetroComboBox cmbAction;
        private System.Windows.Forms.GroupBox grpProcess;
    }
}