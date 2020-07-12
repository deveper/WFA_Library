namespace WFA_Library
{
    partial class UserDesignAdmin
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
            this.mgDataUser = new MetroFramework.Controls.MetroGrid();
            this.mtlUser = new MetroFramework.Controls.MetroLabel();
            this.mtbAdd = new MetroFramework.Controls.MetroButton();
            this.mtbDelete = new MetroFramework.Controls.MetroButton();
            this.mtbUpdate = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtIsbn = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtlBack = new MetroFramework.Controls.MetroLink();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgDataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // mgDataUser
            // 
            this.mgDataUser.AllowUserToResizeRows = false;
            this.mgDataUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mgDataUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgDataUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgDataUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgDataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDataUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgDataUser.EnableHeadersVisualStyles = false;
            this.mgDataUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgDataUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mgDataUser.Location = new System.Drawing.Point(23, 48);
            this.mgDataUser.Name = "mgDataUser";
            this.mgDataUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDataUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgDataUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgDataUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDataUser.Size = new System.Drawing.Size(512, 239);
            this.mgDataUser.TabIndex = 0;
            this.mgDataUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtlUser
            // 
            this.mtlUser.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.mtlUser.AutoSize = true;
            this.mtlUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlUser.Location = new System.Drawing.Point(204, 13);
            this.mtlUser.Name = "mtlUser";
            this.mtlUser.Size = new System.Drawing.Size(117, 25);
            this.mtlUser.TabIndex = 1;
            this.mtlUser.Text = "User Situation";
            this.mtlUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtbAdd
            // 
            this.mtbAdd.Location = new System.Drawing.Point(23, 325);
            this.mtbAdd.Name = "mtbAdd";
            this.mtbAdd.Size = new System.Drawing.Size(100, 44);
            this.mtbAdd.TabIndex = 2;
            this.mtbAdd.Text = "Add";
            this.mtbAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbAdd.UseSelectable = true;
            // 
            // mtbDelete
            // 
            this.mtbDelete.Location = new System.Drawing.Point(23, 375);
            this.mtbDelete.Name = "mtbDelete";
            this.mtbDelete.Size = new System.Drawing.Size(100, 44);
            this.mtbDelete.TabIndex = 3;
            this.mtbDelete.Text = "Delete";
            this.mtbDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbDelete.UseSelectable = true;
            // 
            // mtbUpdate
            // 
            this.mtbUpdate.Location = new System.Drawing.Point(23, 425);
            this.mtbUpdate.Name = "mtbUpdate";
            this.mtbUpdate.Size = new System.Drawing.Size(100, 44);
            this.mtbUpdate.TabIndex = 4;
            this.mtbUpdate.Text = "Update";
            this.mtbUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbUpdate.UseSelectable = true;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(328, 354);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 5;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIsbn
            // 
            // 
            // 
            // 
            this.txtIsbn.CustomButton.Image = null;
            this.txtIsbn.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtIsbn.CustomButton.Name = "";
            this.txtIsbn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIsbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIsbn.CustomButton.TabIndex = 1;
            this.txtIsbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIsbn.CustomButton.UseSelectable = true;
            this.txtIsbn.CustomButton.Visible = false;
            this.txtIsbn.Lines = new string[0];
            this.txtIsbn.Location = new System.Drawing.Point(328, 383);
            this.txtIsbn.MaxLength = 32767;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.PasswordChar = '\0';
            this.txtIsbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIsbn.SelectedText = "";
            this.txtIsbn.SelectionLength = 0;
            this.txtIsbn.SelectionStart = 0;
            this.txtIsbn.ShortcutsEnabled = true;
            this.txtIsbn.Size = new System.Drawing.Size(207, 23);
            this.txtIsbn.TabIndex = 6;
            this.txtIsbn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtIsbn.UseSelectable = true;
            this.txtIsbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIsbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(243, 354);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "User Name:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(255, 386);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Password:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtlBack
            // 
            this.mtlBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mtlBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtlBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlBack.ImageSize = 25;
            this.mtlBack.Location = new System.Drawing.Point(493, 461);
            this.mtlBack.Name = "mtlBack";
            this.mtlBack.Size = new System.Drawing.Size(42, 35);
            this.mtlBack.TabIndex = 15;
            this.mtlBack.Text = "Back";
            this.mtlBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtlBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtlBack.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(328, 412);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(207, 29);
            this.metroComboBox1.TabIndex = 16;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(256, 416);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Authority:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[] {
        "Search"};
            this.txtSearch.Location = new System.Drawing.Point(328, 325);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(207, 23);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 501);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.mtlBack);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mtbUpdate);
            this.Controls.Add(this.mtbDelete);
            this.Controls.Add(this.mtbAdd);
            this.Controls.Add(this.mtlUser);
            this.Controls.Add(this.mgDataUser);
            this.Name = "UserDesign";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.mgDataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgDataUser;
        private MetroFramework.Controls.MetroLabel mtlUser;
        private MetroFramework.Controls.MetroButton mtbAdd;
        private MetroFramework.Controls.MetroButton mtbDelete;
        private MetroFramework.Controls.MetroButton mtbUpdate;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtIsbn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink mtlBack;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}