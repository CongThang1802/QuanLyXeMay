
namespace QuanLy_CuaHang.HoaDon
{
    partial class HD_BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HD_BanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Tim_HD = new Guna.UI.WinForms.GunaCircleButton();
            this.txt_Tim_HD = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_HD = new Guna.UI.WinForms.GunaDataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.txtTongTien = new Guna.UI.WinForms.GunaTextBox();
            this.dateHD = new System.Windows.Forms.DateTimePicker();
            this.txtTenKh = new Guna.UI.WinForms.GunaTextBox();
            this.txtTenNV = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tim_HD
            // 
            this.btn_Tim_HD.AnimationHoverSpeed = 0.07F;
            this.btn_Tim_HD.AnimationSpeed = 0.03F;
            this.btn_Tim_HD.BaseColor = System.Drawing.Color.White;
            this.btn_Tim_HD.BorderColor = System.Drawing.Color.Black;
            this.btn_Tim_HD.BorderSize = 1;
            this.btn_Tim_HD.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Tim_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Tim_HD.ForeColor = System.Drawing.Color.White;
            this.btn_Tim_HD.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim_HD.Image")));
            this.btn_Tim_HD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Tim_HD.Location = new System.Drawing.Point(724, 33);
            this.btn_Tim_HD.Name = "btn_Tim_HD";
            this.btn_Tim_HD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Tim_HD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Tim_HD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Tim_HD.OnHoverImage = null;
            this.btn_Tim_HD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Tim_HD.Size = new System.Drawing.Size(35, 35);
            this.btn_Tim_HD.TabIndex = 25;
            this.btn_Tim_HD.Click += new System.EventHandler(this.btn_Tim_HD_Click);
            // 
            // txt_Tim_HD
            // 
            this.txt_Tim_HD.BackColor = System.Drawing.Color.Transparent;
            this.txt_Tim_HD.BaseColor = System.Drawing.Color.White;
            this.txt_Tim_HD.BorderColor = System.Drawing.Color.Silver;
            this.txt_Tim_HD.BorderSize = 1;
            this.txt_Tim_HD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tim_HD.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Tim_HD.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Tim_HD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Tim_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tim_HD.Location = new System.Drawing.Point(528, 33);
            this.txt_Tim_HD.Name = "txt_Tim_HD";
            this.txt_Tim_HD.PasswordChar = '\0';
            this.txt_Tim_HD.Radius = 12;
            this.txt_Tim_HD.Size = new System.Drawing.Size(160, 30);
            this.txt_Tim_HD.TabIndex = 24;
            // 
            // dgv_HD
            // 
            this.dgv_HD.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_HD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HD.BackgroundColor = System.Drawing.Color.White;
            this.dgv_HD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_HD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HD.ColumnHeadersHeight = 21;
            this.dgv_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.tennv,
            this.tenkh,
            this.ngaylap,
            this.tongtien,
            this.chitiet});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HD.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_HD.EnableHeadersVisualStyles = false;
            this.dgv_HD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HD.Location = new System.Drawing.Point(3, 226);
            this.dgv_HD.Name = "dgv_HD";
            this.dgv_HD.ReadOnly = true;
            this.dgv_HD.RowHeadersVisible = false;
            this.dgv_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HD.Size = new System.Drawing.Size(884, 299);
            this.dgv_HD.TabIndex = 26;
            this.dgv_HD.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_HD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_HD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_HD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_HD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_HD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_HD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_HD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_HD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_HD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_HD.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_HD.ThemeStyle.ReadOnly = true;
            this.dgv_HD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_HD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_HD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_HD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_HD.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_HD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_HD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_HD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HD_CellClick);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "ma_hd";
            this.mahd.HeaderText = "Mã Hóa Đơn";
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "ten_nv";
            this.tennv.HeaderText = "Tên Nhân Viên";
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "ten_hk";
            this.tenkh.HeaderText = "Tên Khách Hàng";
            this.tenkh.Name = "tenkh";
            this.tenkh.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap_hd";
            this.ngaylap.HeaderText = "Ngày Lập";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "thanhtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // chitiet
            // 
            this.chitiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Chi Tiết";
            this.chitiet.DefaultCellStyle = dataGridViewCellStyle3;
            this.chitiet.HeaderText = "Chi Tiết";
            this.chitiet.Name = "chitiet";
            this.chitiet.ReadOnly = true;
            this.chitiet.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tổng Tiền";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.Location = new System.Drawing.Point(128, 86);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.Radius = 10;
            this.txtID.Size = new System.Drawing.Size(160, 30);
            this.txtID.TabIndex = 32;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.Transparent;
            this.txtTongTien.BaseColor = System.Drawing.Color.White;
            this.txtTongTien.BorderColor = System.Drawing.Color.Silver;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTongTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTongTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongTien.Location = new System.Drawing.Point(755, 141);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.Radius = 10;
            this.txtTongTien.Size = new System.Drawing.Size(119, 26);
            this.txtTongTien.TabIndex = 35;
            // 
            // dateHD
            // 
            this.dateHD.CustomFormat = "yyyy/MM/dd";
            this.dateHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHD.Location = new System.Drawing.Point(512, 147);
            this.dateHD.Name = "dateHD";
            this.dateHD.Size = new System.Drawing.Size(134, 20);
            this.dateHD.TabIndex = 36;
            this.dateHD.Value = new System.DateTime(2020, 12, 23, 0, 0, 0, 0);
            // 
            // txtTenKh
            // 
            this.txtTenKh.BackColor = System.Drawing.Color.Transparent;
            this.txtTenKh.BaseColor = System.Drawing.Color.White;
            this.txtTenKh.BorderColor = System.Drawing.Color.Silver;
            this.txtTenKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKh.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenKh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenKh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenKh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKh.Location = new System.Drawing.Point(512, 86);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.PasswordChar = '\0';
            this.txtTenKh.Radius = 10;
            this.txtTenKh.Size = new System.Drawing.Size(160, 30);
            this.txtTenKh.TabIndex = 38;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNV.BaseColor = System.Drawing.Color.White;
            this.txtTenNV.BorderColor = System.Drawing.Color.Silver;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNV.Location = new System.Drawing.Point(128, 137);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.Radius = 10;
            this.txtTenNV.Size = new System.Drawing.Size(160, 30);
            this.txtTenNV.TabIndex = 39;
            // 
            // HD_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtTenKh);
            this.Controls.Add(this.dateHD);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_HD);
            this.Controls.Add(this.btn_Tim_HD);
            this.Controls.Add(this.txt_Tim_HD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HD_BanHang";
            this.Size = new System.Drawing.Size(902, 528);
            this.Load += new System.EventHandler(this.HD_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleButton btn_Tim_HD;
        private Guna.UI.WinForms.GunaTextBox txt_Tim_HD;
        private Guna.UI.WinForms.GunaDataGridView dgv_HD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private Guna.UI.WinForms.GunaTextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dateHD;
        private Guna.UI.WinForms.GunaTextBox txtTenKh;
        private Guna.UI.WinForms.GunaTextBox txtTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewButtonColumn chitiet;
    }
}
