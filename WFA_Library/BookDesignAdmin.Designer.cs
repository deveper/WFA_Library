namespace WFA_Library
{
    partial class BookDesignAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mgDataBook = new MetroFramework.Controls.MetroGrid();
            this.mtlBook = new MetroFramework.Controls.MetroLabel();
            this.mtbAdd = new MetroFramework.Controls.MetroButton();
            this.mtbDelete = new MetroFramework.Controls.MetroButton();
            this.mtbUpdate = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtIsbn = new MetroFramework.Controls.MetroTextBox();
            this.txtTotalQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mdtReleaseDate = new MetroFramework.Controls.MetroDateTime();
            this.mtlBack = new MetroFramework.Controls.MetroLink();
            this.mtbAuthorDetails = new MetroFramework.Controls.MetroButton();
            this.mtbBookTypeDetail = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgDataBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mgDataBook
            // 
            this.mgDataBook.AllowUserToResizeRows = false;
            this.mgDataBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mgDataBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgDataBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgDataBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDataBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.mgDataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDataBook.DefaultCellStyle = dataGridViewCellStyle26;
            this.mgDataBook.EnableHeadersVisualStyles = false;
            this.mgDataBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgDataBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mgDataBook.Location = new System.Drawing.Point(11, 39);
            this.mgDataBook.Name = "mgDataBook";
            this.mgDataBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDataBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.mgDataBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgDataBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDataBook.Size = new System.Drawing.Size(1128, 239);
            this.mgDataBook.TabIndex = 0;
            this.mgDataBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtlBook
            // 
            this.mtlBook.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.mtlBook.AutoSize = true;
            this.mtlBook.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mtlBook.Location = new System.Drawing.Point(515, 11);
            this.mtlBook.Name = "mtlBook";
            this.mtlBook.Size = new System.Drawing.Size(121, 25);
            this.mtlBook.TabIndex = 1;
            this.mtlBook.Text = "Book Situation";
            this.mtlBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtlBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtbAdd
            // 
            this.mtbAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbAdd.Location = new System.Drawing.Point(11, 300);
            this.mtbAdd.Name = "mtbAdd";
            this.mtbAdd.Size = new System.Drawing.Size(100, 60);
            this.mtbAdd.TabIndex = 2;
            this.mtbAdd.Text = "Add";
            this.mtbAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbAdd.UseSelectable = true;
            this.mtbAdd.Click += new System.EventHandler(this.mtbAdd_Click);
            // 
            // mtbDelete
            // 
            this.mtbDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbDelete.Location = new System.Drawing.Point(11, 375);
            this.mtbDelete.Name = "mtbDelete";
            this.mtbDelete.Size = new System.Drawing.Size(100, 60);
            this.mtbDelete.TabIndex = 3;
            this.mtbDelete.Text = "Delete";
            this.mtbDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbDelete.UseSelectable = true;
            // 
            // mtbUpdate
            // 
            this.mtbUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbUpdate.Location = new System.Drawing.Point(11, 449);
            this.mtbUpdate.Name = "mtbUpdate";
            this.mtbUpdate.Size = new System.Drawing.Size(100, 60);
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
            this.txtName.Location = new System.Drawing.Point(221, 342);
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
            this.txtIsbn.Location = new System.Drawing.Point(221, 371);
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
            // txtTotalQuantity
            // 
            // 
            // 
            // 
            this.txtTotalQuantity.CustomButton.Image = null;
            this.txtTotalQuantity.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtTotalQuantity.CustomButton.Name = "";
            this.txtTotalQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalQuantity.CustomButton.TabIndex = 1;
            this.txtTotalQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalQuantity.CustomButton.UseSelectable = true;
            this.txtTotalQuantity.CustomButton.Visible = false;
            this.txtTotalQuantity.Lines = new string[0];
            this.txtTotalQuantity.Location = new System.Drawing.Point(221, 400);
            this.txtTotalQuantity.MaxLength = 32767;
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.PasswordChar = '\0';
            this.txtTotalQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalQuantity.SelectedText = "";
            this.txtTotalQuantity.SelectionLength = 0;
            this.txtTotalQuantity.SelectionStart = 0;
            this.txtTotalQuantity.ShortcutsEnabled = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(207, 23);
            this.txtTotalQuantity.TabIndex = 7;
            this.txtTotalQuantity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTotalQuantity.UseSelectable = true;
            this.txtTotalQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(775, 300);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Select BookType";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(158, 371);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Isbn No:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(123, 400);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Total Quantity:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mdtReleaseDate
            // 
            this.mdtReleaseDate.Location = new System.Drawing.Point(221, 429);
            this.mdtReleaseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtReleaseDate.Name = "mdtReleaseDate";
            this.mdtReleaseDate.Size = new System.Drawing.Size(207, 29);
            this.mdtReleaseDate.TabIndex = 13;
            this.mdtReleaseDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtlBack
            // 
            this.mtlBack.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mtlBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtlBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtlBack.ImageSize = 25;
            this.mtlBack.Location = new System.Drawing.Point(1084, 495);
            this.mtlBack.Name = "mtlBack";
            this.mtlBack.Size = new System.Drawing.Size(44, 20);
            this.mtlBack.TabIndex = 15;
            this.mtlBack.Text = "Back";
            this.mtlBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtlBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtlBack.UseSelectable = true;
            // 
            // mtbAuthorDetails
            // 
            this.mtbAuthorDetails.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbAuthorDetails.Location = new System.Drawing.Point(938, 300);
            this.mtbAuthorDetails.Name = "mtbAuthorDetails";
            this.mtbAuthorDetails.Size = new System.Drawing.Size(201, 33);
            this.mtbAuthorDetails.TabIndex = 21;
            this.mtbAuthorDetails.Text = "Author Details";
            this.mtbAuthorDetails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbAuthorDetails.UseSelectable = true;
            this.mtbAuthorDetails.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // mtbBookTypeDetail
            // 
            this.mtbBookTypeDetail.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mtbBookTypeDetail.Location = new System.Drawing.Point(938, 342);
            this.mtbBookTypeDetail.Name = "mtbBookTypeDetail";
            this.mtbBookTypeDetail.Size = new System.Drawing.Size(201, 33);
            this.mtbBookTypeDetail.TabIndex = 20;
            this.mtbBookTypeDetail.Text = "Book Type Details";
            this.mtbBookTypeDetail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbBookTypeDetail.UseSelectable = true;
            this.mtbBookTypeDetail.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(128, 431);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Relaese Date:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(540, 300);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(92, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Select Authors";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(133, 344);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(82, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Book Name:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(454, 323);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 186);
            this.listBox1.TabIndex = 25;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(740, 323);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 186);
            this.listBox2.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(221, 480);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 29);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Search...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BookDesignAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 521);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mtbAuthorDetails);
            this.Controls.Add(this.mtbBookTypeDetail);
            this.Controls.Add(this.mtlBack);
            this.Controls.Add(this.mdtReleaseDate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtTotalQuantity);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mtbUpdate);
            this.Controls.Add(this.mtbDelete);
            this.Controls.Add(this.mtbAdd);
            this.Controls.Add(this.mtlBook);
            this.Controls.Add(this.mgDataBook);
            this.Name = "BookDesignAdmin";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.BookDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgDataBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgDataBook;
        private MetroFramework.Controls.MetroLabel mtlBook;
        private MetroFramework.Controls.MetroButton mtbAdd;
        private MetroFramework.Controls.MetroButton mtbDelete;
        private MetroFramework.Controls.MetroButton mtbUpdate;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtIsbn;
        private MetroFramework.Controls.MetroTextBox txtTotalQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime mdtReleaseDate;
        private MetroFramework.Controls.MetroLink mtlBack;
        private MetroFramework.Controls.MetroButton mtbBookTypeDetail;
        private MetroFramework.Controls.MetroButton mtbAuthorDetails;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
    }
}