
namespace QuanLy_CuaHang.SanPham1
{
    partial class UC_DanhM_LoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhM_LoaiSP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Tim_LSP = new Guna.UI.WinForms.GunaCircleButton();
            this.txt_Tim_LSP = new Guna.UI.WinForms.GunaTextBox();
            this.btn_LamMoi_LSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Xoa_LSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Sua_LSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Them_LSP = new Guna.UI.WinForms.GunaCircleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Tim_DM = new Guna.UI.WinForms.GunaCircleButton();
            this.txt_Tim_DM = new Guna.UI.WinForms.GunaTextBox();
            this.btn_LamMoi_DM = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Xoa_DM = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Sua_DM = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Them_DM = new Guna.UI.WinForms.GunaCircleButton();
            this.dgv_LoaiSP = new Guna.UI.WinForms.GunaDataGridView();
            this.dgv_DanhMuc = new Guna.UI.WinForms.GunaDataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_LoaiSP);
            this.groupBox2.Controls.Add(this.btn_Tim_LSP);
            this.groupBox2.Controls.Add(this.txt_Tim_LSP);
            this.groupBox2.Controls.Add(this.btn_LamMoi_LSP);
            this.groupBox2.Controls.Add(this.btn_Xoa_LSP);
            this.groupBox2.Controls.Add(this.btn_Sua_LSP);
            this.groupBox2.Controls.Add(this.btn_Them_LSP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(445, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 515);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại sản phẩm";
            // 
            // btn_Tim_LSP
            // 
            this.btn_Tim_LSP.AnimationHoverSpeed = 0.07F;
            this.btn_Tim_LSP.AnimationSpeed = 0.03F;
            this.btn_Tim_LSP.BaseColor = System.Drawing.Color.White;
            this.btn_Tim_LSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Tim_LSP.BorderSize = 1;
            this.btn_Tim_LSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Tim_LSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Tim_LSP.ForeColor = System.Drawing.Color.White;
            this.btn_Tim_LSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim_LSP.Image")));
            this.btn_Tim_LSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Tim_LSP.Location = new System.Drawing.Point(376, 34);
            this.btn_Tim_LSP.Name = "btn_Tim_LSP";
            this.btn_Tim_LSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Tim_LSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Tim_LSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Tim_LSP.OnHoverImage = null;
            this.btn_Tim_LSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Tim_LSP.Size = new System.Drawing.Size(35, 35);
            this.btn_Tim_LSP.TabIndex = 17;
            this.btn_Tim_LSP.Click += new System.EventHandler(this.btn_Tim_LSP_Click);
            // 
            // txt_Tim_LSP
            // 
            this.txt_Tim_LSP.BackColor = System.Drawing.Color.Transparent;
            this.txt_Tim_LSP.BaseColor = System.Drawing.Color.White;
            this.txt_Tim_LSP.BorderColor = System.Drawing.Color.Silver;
            this.txt_Tim_LSP.BorderSize = 1;
            this.txt_Tim_LSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tim_LSP.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Tim_LSP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Tim_LSP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Tim_LSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tim_LSP.Location = new System.Drawing.Point(214, 36);
            this.txt_Tim_LSP.Name = "txt_Tim_LSP";
            this.txt_Tim_LSP.PasswordChar = '\0';
            this.txt_Tim_LSP.Radius = 12;
            this.txt_Tim_LSP.Size = new System.Drawing.Size(160, 30);
            this.txt_Tim_LSP.TabIndex = 16;
            // 
            // btn_LamMoi_LSP
            // 
            this.btn_LamMoi_LSP.AnimationHoverSpeed = 0.07F;
            this.btn_LamMoi_LSP.AnimationSpeed = 0.03F;
            this.btn_LamMoi_LSP.BaseColor = System.Drawing.Color.White;
            this.btn_LamMoi_LSP.BorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_LSP.BorderSize = 1;
            this.btn_LamMoi_LSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LamMoi_LSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LamMoi_LSP.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_LSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi_LSP.Image")));
            this.btn_LamMoi_LSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_LamMoi_LSP.Location = new System.Drawing.Point(12, 157);
            this.btn_LamMoi_LSP.Name = "btn_LamMoi_LSP";
            this.btn_LamMoi_LSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_LamMoi_LSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_LSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_LSP.OnHoverImage = null;
            this.btn_LamMoi_LSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_LamMoi_LSP.Size = new System.Drawing.Size(35, 35);
            this.btn_LamMoi_LSP.TabIndex = 13;
            this.btn_LamMoi_LSP.Click += new System.EventHandler(this.btn_LamMoi_LSP_Click);
            // 
            // btn_Xoa_LSP
            // 
            this.btn_Xoa_LSP.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_LSP.AnimationSpeed = 0.03F;
            this.btn_Xoa_LSP.BaseColor = System.Drawing.Color.White;
            this.btn_Xoa_LSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_LSP.BorderSize = 1;
            this.btn_Xoa_LSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_LSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_LSP.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_LSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa_LSP.Image")));
            this.btn_Xoa_LSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_LSP.Location = new System.Drawing.Point(12, 116);
            this.btn_Xoa_LSP.Name = "btn_Xoa_LSP";
            this.btn_Xoa_LSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_LSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_LSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_LSP.OnHoverImage = null;
            this.btn_Xoa_LSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_LSP.Size = new System.Drawing.Size(35, 35);
            this.btn_Xoa_LSP.TabIndex = 2;
            this.btn_Xoa_LSP.Click += new System.EventHandler(this.btn_Xoa_LSP_Click);
            // 
            // btn_Sua_LSP
            // 
            this.btn_Sua_LSP.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_LSP.AnimationSpeed = 0.03F;
            this.btn_Sua_LSP.BaseColor = System.Drawing.Color.White;
            this.btn_Sua_LSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_LSP.BorderSize = 1;
            this.btn_Sua_LSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_LSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_LSP.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_LSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua_LSP.Image")));
            this.btn_Sua_LSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_LSP.Location = new System.Drawing.Point(12, 75);
            this.btn_Sua_LSP.Name = "btn_Sua_LSP";
            this.btn_Sua_LSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_LSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_LSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_LSP.OnHoverImage = null;
            this.btn_Sua_LSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_LSP.Size = new System.Drawing.Size(35, 35);
            this.btn_Sua_LSP.TabIndex = 1;
            this.btn_Sua_LSP.Click += new System.EventHandler(this.btn_Sua_LSP_Click);
            // 
            // btn_Them_LSP
            // 
            this.btn_Them_LSP.AnimationHoverSpeed = 0.07F;
            this.btn_Them_LSP.AnimationSpeed = 0.03F;
            this.btn_Them_LSP.BaseColor = System.Drawing.Color.White;
            this.btn_Them_LSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_LSP.BorderSize = 1;
            this.btn_Them_LSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_LSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_LSP.ForeColor = System.Drawing.Color.White;
            this.btn_Them_LSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_LSP.Image")));
            this.btn_Them_LSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_LSP.Location = new System.Drawing.Point(12, 34);
            this.btn_Them_LSP.Name = "btn_Them_LSP";
            this.btn_Them_LSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_LSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_LSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_LSP.OnHoverImage = null;
            this.btn_Them_LSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_LSP.Size = new System.Drawing.Size(35, 35);
            this.btn_Them_LSP.TabIndex = 0;
            this.btn_Them_LSP.Click += new System.EventHandler(this.btn_Them_LSP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhMuc);
            this.groupBox1.Controls.Add(this.btn_Tim_DM);
            this.groupBox1.Controls.Add(this.txt_Tim_DM);
            this.groupBox1.Controls.Add(this.btn_LamMoi_DM);
            this.groupBox1.Controls.Add(this.btn_Xoa_DM);
            this.groupBox1.Controls.Add(this.btn_Sua_DM);
            this.groupBox1.Controls.Add(this.btn_Them_DM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 515);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // btn_Tim_DM
            // 
            this.btn_Tim_DM.AnimationHoverSpeed = 0.07F;
            this.btn_Tim_DM.AnimationSpeed = 0.03F;
            this.btn_Tim_DM.BaseColor = System.Drawing.Color.White;
            this.btn_Tim_DM.BorderColor = System.Drawing.Color.Black;
            this.btn_Tim_DM.BorderSize = 1;
            this.btn_Tim_DM.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Tim_DM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Tim_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Tim_DM.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim_DM.Image")));
            this.btn_Tim_DM.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Tim_DM.Location = new System.Drawing.Point(376, 34);
            this.btn_Tim_DM.Name = "btn_Tim_DM";
            this.btn_Tim_DM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Tim_DM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Tim_DM.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Tim_DM.OnHoverImage = null;
            this.btn_Tim_DM.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Tim_DM.Size = new System.Drawing.Size(35, 35);
            this.btn_Tim_DM.TabIndex = 16;
            this.btn_Tim_DM.Click += new System.EventHandler(this.btn_Tim_DM_Click);
            // 
            // txt_Tim_DM
            // 
            this.txt_Tim_DM.BackColor = System.Drawing.Color.Transparent;
            this.txt_Tim_DM.BaseColor = System.Drawing.Color.White;
            this.txt_Tim_DM.BorderColor = System.Drawing.Color.Silver;
            this.txt_Tim_DM.BorderSize = 1;
            this.txt_Tim_DM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tim_DM.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Tim_DM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Tim_DM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Tim_DM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tim_DM.Location = new System.Drawing.Point(214, 36);
            this.txt_Tim_DM.Name = "txt_Tim_DM";
            this.txt_Tim_DM.PasswordChar = '\0';
            this.txt_Tim_DM.Radius = 12;
            this.txt_Tim_DM.Size = new System.Drawing.Size(160, 30);
            this.txt_Tim_DM.TabIndex = 15;
            // 
            // btn_LamMoi_DM
            // 
            this.btn_LamMoi_DM.AnimationHoverSpeed = 0.07F;
            this.btn_LamMoi_DM.AnimationSpeed = 0.03F;
            this.btn_LamMoi_DM.BaseColor = System.Drawing.Color.White;
            this.btn_LamMoi_DM.BorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_DM.BorderSize = 1;
            this.btn_LamMoi_DM.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LamMoi_DM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LamMoi_DM.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_DM.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi_DM.Image")));
            this.btn_LamMoi_DM.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_LamMoi_DM.Location = new System.Drawing.Point(12, 157);
            this.btn_LamMoi_DM.Name = "btn_LamMoi_DM";
            this.btn_LamMoi_DM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_LamMoi_DM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_DM.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_DM.OnHoverImage = null;
            this.btn_LamMoi_DM.OnPressedColor = System.Drawing.Color.Black;
            this.btn_LamMoi_DM.Size = new System.Drawing.Size(35, 35);
            this.btn_LamMoi_DM.TabIndex = 13;
            this.btn_LamMoi_DM.Click += new System.EventHandler(this.btn_LamMoi_DM_Click);
            // 
            // btn_Xoa_DM
            // 
            this.btn_Xoa_DM.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_DM.AnimationSpeed = 0.03F;
            this.btn_Xoa_DM.BaseColor = System.Drawing.Color.White;
            this.btn_Xoa_DM.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_DM.BorderSize = 1;
            this.btn_Xoa_DM.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_DM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_DM.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa_DM.Image")));
            this.btn_Xoa_DM.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_DM.Location = new System.Drawing.Point(12, 116);
            this.btn_Xoa_DM.Name = "btn_Xoa_DM";
            this.btn_Xoa_DM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_DM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_DM.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_DM.OnHoverImage = null;
            this.btn_Xoa_DM.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_DM.Size = new System.Drawing.Size(35, 35);
            this.btn_Xoa_DM.TabIndex = 2;
            this.btn_Xoa_DM.Click += new System.EventHandler(this.btn_Xoa_DM_Click);
            // 
            // btn_Sua_DM
            // 
            this.btn_Sua_DM.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_DM.AnimationSpeed = 0.03F;
            this.btn_Sua_DM.BaseColor = System.Drawing.Color.White;
            this.btn_Sua_DM.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_DM.BorderSize = 1;
            this.btn_Sua_DM.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_DM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_DM.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua_DM.Image")));
            this.btn_Sua_DM.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_DM.Location = new System.Drawing.Point(12, 75);
            this.btn_Sua_DM.Name = "btn_Sua_DM";
            this.btn_Sua_DM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_DM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_DM.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_DM.OnHoverImage = null;
            this.btn_Sua_DM.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_DM.Size = new System.Drawing.Size(35, 35);
            this.btn_Sua_DM.TabIndex = 1;
            this.btn_Sua_DM.Click += new System.EventHandler(this.btn_Sua_DM_Click);
            // 
            // btn_Them_DM
            // 
            this.btn_Them_DM.AnimationHoverSpeed = 0.07F;
            this.btn_Them_DM.AnimationSpeed = 0.03F;
            this.btn_Them_DM.BaseColor = System.Drawing.Color.White;
            this.btn_Them_DM.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_DM.BorderSize = 1;
            this.btn_Them_DM.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_DM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Them_DM.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_DM.Image")));
            this.btn_Them_DM.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_DM.Location = new System.Drawing.Point(12, 34);
            this.btn_Them_DM.Name = "btn_Them_DM";
            this.btn_Them_DM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_DM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_DM.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_DM.OnHoverImage = null;
            this.btn_Them_DM.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_DM.Size = new System.Drawing.Size(35, 35);
            this.btn_Them_DM.TabIndex = 0;
            this.btn_Them_DM.Click += new System.EventHandler(this.btn_Them_DM_Click);
            // 
            // dgv_LoaiSP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_LoaiSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_LoaiSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloai,
            this.ten});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LoaiSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_LoaiSP.EnableHeadersVisualStyles = false;
            this.dgv_LoaiSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_LoaiSP.Location = new System.Drawing.Point(73, 75);
            this.dgv_LoaiSP.Name = "dgv_LoaiSP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_LoaiSP.RowHeadersVisible = false;
            this.dgv_LoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiSP.Size = new System.Drawing.Size(338, 415);
            this.dgv_LoaiSP.TabIndex = 19;
            this.dgv_LoaiSP.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_LoaiSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_LoaiSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_LoaiSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_LoaiSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_LoaiSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_LoaiSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_LoaiSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_LoaiSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_LoaiSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_LoaiSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiSP.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_LoaiSP.ThemeStyle.ReadOnly = false;
            this.dgv_LoaiSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_LoaiSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_LoaiSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_LoaiSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_LoaiSP.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_LoaiSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_LoaiSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgv_DanhMuc
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_DanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhMuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DanhMuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.tendm});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhMuc.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_DanhMuc.EnableHeadersVisualStyles = false;
            this.dgv_DanhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DanhMuc.Location = new System.Drawing.Point(64, 75);
            this.dgv_DanhMuc.Name = "dgv_DanhMuc";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhMuc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_DanhMuc.RowHeadersVisible = false;
            this.dgv_DanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhMuc.Size = new System.Drawing.Size(347, 415);
            this.dgv_DanhMuc.TabIndex = 17;
            this.dgv_DanhMuc.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_DanhMuc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhMuc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DanhMuc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhMuc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhMuc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DanhMuc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DanhMuc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DanhMuc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_DanhMuc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhMuc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMuc.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_DanhMuc.ThemeStyle.ReadOnly = false;
            this.dgv_DanhMuc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DanhMuc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DanhMuc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_DanhMuc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DanhMuc.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_DanhMuc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DanhMuc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma_dm";
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            // 
            // tendm
            // 
            this.tendm.DataPropertyName = "ten_dm";
            this.tendm.HeaderText = "Tên";
            this.tendm.Name = "tendm";
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "ma_loai";
            this.maloai.HeaderText = "Mã Loại";
            this.maloai.Name = "maloai";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten_loai";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            // 
            // UC_DanhM_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_DanhM_LoaiSP";
            this.Size = new System.Drawing.Size(886, 523);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaCircleButton btn_LamMoi_LSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Xoa_LSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Sua_LSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_LSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaCircleButton btn_LamMoi_DM;
        private Guna.UI.WinForms.GunaCircleButton btn_Xoa_DM;
        private Guna.UI.WinForms.GunaCircleButton btn_Sua_DM;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_DM;
        private Guna.UI.WinForms.GunaCircleButton btn_Tim_LSP;
        private Guna.UI.WinForms.GunaTextBox txt_Tim_LSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Tim_DM;
        private Guna.UI.WinForms.GunaTextBox txt_Tim_DM;
        private Guna.UI.WinForms.GunaDataGridView dgv_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private Guna.UI.WinForms.GunaDataGridView dgv_DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendm;
    }
}
