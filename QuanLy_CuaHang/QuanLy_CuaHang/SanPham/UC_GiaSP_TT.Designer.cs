
namespace QuanLy_CuaHang.SanPham
{
    partial class UC_GiaSP_TT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GiaSP_TT));
            this.ckb_LocSP = new Guna.UI.WinForms.GunaCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.cbb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.dgv_GiaSP = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_LamMoi_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Xoa_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Sua_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Them_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaSP)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb_LocSP
            // 
            this.ckb_LocSP.BaseColor = System.Drawing.Color.White;
            this.ckb_LocSP.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckb_LocSP.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ckb_LocSP.FillColor = System.Drawing.Color.White;
            this.ckb_LocSP.Location = new System.Drawing.Point(94, 26);
            this.ckb_LocSP.Name = "ckb_LocSP";
            this.ckb_LocSP.Size = new System.Drawing.Size(104, 20);
            this.ckb_LocSP.TabIndex = 36;
            this.ckb_LocSP.Text = "Lọc Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hãng";
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.Enabled = false;
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(427, 26);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(121, 21);
            this.cbb_Loai.TabIndex = 33;
            // 
            // cbb_DanhMuc
            // 
            this.cbb_DanhMuc.Enabled = false;
            this.cbb_DanhMuc.FormattingEnabled = true;
            this.cbb_DanhMuc.Location = new System.Drawing.Point(253, 26);
            this.cbb_DanhMuc.Name = "cbb_DanhMuc";
            this.cbb_DanhMuc.Size = new System.Drawing.Size(121, 21);
            this.cbb_DanhMuc.TabIndex = 32;
            // 
            // dgv_GiaSP
            // 
            this.dgv_GiaSP.AllowUserToAddRows = false;
            this.dgv_GiaSP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_GiaSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GiaSP.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GiaSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_GiaSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_GiaSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_GiaSP.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_GiaSP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_GiaSP.EnableHeadersVisualStyles = false;
            this.dgv_GiaSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.Location = new System.Drawing.Point(76, 61);
            this.dgv_GiaSP.MultiSelect = false;
            this.dgv_GiaSP.Name = "dgv_GiaSP";
            this.dgv_GiaSP.ReadOnly = true;
            this.dgv_GiaSP.RowHeadersVisible = false;
            this.dgv_GiaSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GiaSP.Size = new System.Drawing.Size(794, 444);
            this.dgv_GiaSP.TabIndex = 31;
            this.dgv_GiaSP.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_GiaSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_GiaSP.ThemeStyle.ReadOnly = true;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_GiaSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_GiaSP.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_GiaSP.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiaSP_CellContentClick);
            // 
            // btn_LamMoi_GiaSP
            // 
            this.btn_LamMoi_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_LamMoi_GiaSP.AnimationSpeed = 0.03F;
            this.btn_LamMoi_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_LamMoi_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_GiaSP.BorderSize = 1;
            this.btn_LamMoi_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LamMoi_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LamMoi_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi_GiaSP.Image")));
            this.btn_LamMoi_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_LamMoi_GiaSP.Location = new System.Drawing.Point(20, 143);
            this.btn_LamMoi_GiaSP.Name = "btn_LamMoi_GiaSP";
            this.btn_LamMoi_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_LamMoi_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_GiaSP.OnHoverImage = null;
            this.btn_LamMoi_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_LamMoi_GiaSP.Size = new System.Drawing.Size(35, 35);
            this.btn_LamMoi_GiaSP.TabIndex = 30;
            this.btn_LamMoi_GiaSP.Click += new System.EventHandler(this.btn_LamMoi_GiaSP_Click);
            // 
            // btn_Xoa_GiaSP
            // 
            this.btn_Xoa_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_GiaSP.AnimationSpeed = 0.03F;
            this.btn_Xoa_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_Xoa_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_GiaSP.BorderSize = 1;
            this.btn_Xoa_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa_GiaSP.Image")));
            this.btn_Xoa_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_GiaSP.Location = new System.Drawing.Point(20, 102);
            this.btn_Xoa_GiaSP.Name = "btn_Xoa_GiaSP";
            this.btn_Xoa_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_GiaSP.OnHoverImage = null;
            this.btn_Xoa_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_GiaSP.Size = new System.Drawing.Size(35, 35);
            this.btn_Xoa_GiaSP.TabIndex = 29;
            this.btn_Xoa_GiaSP.Click += new System.EventHandler(this.btn_Xoa_GiaSP_Click);
            // 
            // btn_Sua_GiaSP
            // 
            this.btn_Sua_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_GiaSP.AnimationSpeed = 0.03F;
            this.btn_Sua_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_Sua_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_GiaSP.BorderSize = 1;
            this.btn_Sua_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua_GiaSP.Image")));
            this.btn_Sua_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_GiaSP.Location = new System.Drawing.Point(20, 61);
            this.btn_Sua_GiaSP.Name = "btn_Sua_GiaSP";
            this.btn_Sua_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_GiaSP.OnHoverImage = null;
            this.btn_Sua_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_GiaSP.Size = new System.Drawing.Size(35, 35);
            this.btn_Sua_GiaSP.TabIndex = 28;
            this.btn_Sua_GiaSP.Click += new System.EventHandler(this.btn_Sua_GiaSP_Click);
            // 
            // btn_Them_GiaSP
            // 
            this.btn_Them_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_Them_GiaSP.AnimationSpeed = 0.03F;
            this.btn_Them_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_Them_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_GiaSP.BorderSize = 1;
            this.btn_Them_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_Them_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_GiaSP.Image")));
            this.btn_Them_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_GiaSP.Location = new System.Drawing.Point(20, 20);
            this.btn_Them_GiaSP.Name = "btn_Them_GiaSP";
            this.btn_Them_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_GiaSP.OnHoverImage = null;
            this.btn_Them_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_GiaSP.Size = new System.Drawing.Size(35, 35);
            this.btn_Them_GiaSP.TabIndex = 27;
            this.btn_Them_GiaSP.Click += new System.EventHandler(this.btn_Them_GiaSP_Click);
            // 
            // UC_GiaSP_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckb_LocSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Loai);
            this.Controls.Add(this.cbb_DanhMuc);
            this.Controls.Add(this.dgv_GiaSP);
            this.Controls.Add(this.btn_LamMoi_GiaSP);
            this.Controls.Add(this.btn_Xoa_GiaSP);
            this.Controls.Add(this.btn_Sua_GiaSP);
            this.Controls.Add(this.btn_Them_GiaSP);
            this.Name = "UC_GiaSP_TT";
            this.Size = new System.Drawing.Size(886, 523);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox ckb_LocSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.ComboBox cbb_DanhMuc;
        private Guna.UI.WinForms.GunaDataGridView dgv_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_LamMoi_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Xoa_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Sua_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_GiaSP;
    }
}
