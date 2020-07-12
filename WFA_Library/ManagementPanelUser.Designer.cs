namespace WFA_Library
{
    partial class ManagementPanelUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtlUserName = new MetroFramework.Controls.MetroLabel();
            this.mtlUserAuthority = new MetroFramework.Controls.MetroLabel();
            this.mtlIp = new MetroFramework.Controls.MetroLabel();
            this.mtlProfile = new MetroFramework.Controls.MetroLabel();
            this.mtgSearch = new MetroFramework.Controls.MetroGrid();
            this.pcbUserPhoto = new System.Windows.Forms.PictureBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.mtbTake = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mtgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mtlUserName
            // 
            this.mtlUserName.AutoSize = true;
            this.mtlUserName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlUserName.Location = new System.Drawing.Point(179, 68);
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
            this.mtlUserAuthority.Location = new System.Drawing.Point(156, 131);
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
            this.mtlIp.Location = new System.Drawing.Point(195, 100);
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
            this.mtlProfile.Location = new System.Drawing.Point(152, 165);
            this.mtlProfile.Name = "mtlProfile";
            this.mtlProfile.Size = new System.Drawing.Size(124, 25);
            this.mtlProfile.TabIndex = 4;
            this.mtlProfile.Text = "Profile Settings";
            this.mtlProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtgSearch
            // 
            this.mtgSearch.AllowUserToResizeRows = false;
            this.mtgSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mtgSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtgSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtgSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtgSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mtgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtgSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtgSearch.EnableHeadersVisualStyles = false;
            this.mtgSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtgSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mtgSearch.Location = new System.Drawing.Point(27, 218);
            this.mtgSearch.Name = "mtgSearch";
            this.mtgSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtgSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mtgSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtgSearch.Size = new System.Drawing.Size(587, 219);
            this.mtgSearch.TabIndex = 12;
            this.mtgSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pcbUserPhoto
            // 
            this.pcbUserPhoto.Location = new System.Drawing.Point(27, 63);
            this.pcbUserPhoto.Name = "pcbUserPhoto";
            this.pcbUserPhoto.Size = new System.Drawing.Size(119, 132);
            this.pcbUserPhoto.TabIndex = 0;
            this.pcbUserPhoto.TabStop = false;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[] {
        "Search"};
            this.txtSearch.Location = new System.Drawing.Point(451, 85);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(158, 23);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbTake
            // 
            this.mtbTake.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbTake.Location = new System.Drawing.Point(451, 131);
            this.mtbTake.Name = "mtbTake";
            this.mtbTake.Size = new System.Drawing.Size(158, 44);
            this.mtbTake.TabIndex = 14;
            this.mtbTake.Text = "Take";
            this.mtbTake.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbTake.UseSelectable = true;
            // 
            // ManagementPanelUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 502);
            this.Controls.Add(this.mtbTake);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.mtgSearch);
            this.Controls.Add(this.mtlProfile);
            this.Controls.Add(this.mtlIp);
            this.Controls.Add(this.mtlUserAuthority);
            this.Controls.Add(this.mtlUserName);
            this.Controls.Add(this.pcbUserPhoto);
            this.Name = "ManagementPanelUser";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Welcome...";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.mtgSearch)).EndInit();
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
        private MetroFramework.Controls.MetroGrid mtgSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton mtbTake;
    }
}