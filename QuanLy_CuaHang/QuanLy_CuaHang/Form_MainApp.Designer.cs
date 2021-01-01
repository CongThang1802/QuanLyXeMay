
namespace QuanLy_CuaHang
{
    partial class Form_MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainApp));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Select = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_NoiDung = new System.Windows.Forms.Panel();
            this.lbl_NguoiDung = new Guna.UI.WinForms.GunaLabel();
            this.gunaTileButton4 = new Guna.UI.WinForms.GunaTileButton();
            this.gunaTileButton3 = new Guna.UI.WinForms.GunaTileButton();
            this.gunaTileButton2 = new Guna.UI.WinForms.GunaTileButton();
            this.gunaTileButton1 = new Guna.UI.WinForms.GunaTileButton();
            this.btn_HOADON = new Guna.UI.WinForms.GunaButton();
            this.btn_SANPHAM = new Guna.UI.WinForms.GunaButton();
            this.btn_KHACHHANG = new Guna.UI.WinForms.GunaButton();
            this.btn_THONGKE = new Guna.UI.WinForms.GunaButton();
            this.btn_NGUOIDUNG = new Guna.UI.WinForms.GunaButton();
            this.btn_DATA = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 17);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.pnl_Select);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 601);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_HOADON);
            this.flowLayoutPanel1.Controls.Add(this.btn_SANPHAM);
            this.flowLayoutPanel1.Controls.Add(this.btn_KHACHHANG);
            this.flowLayoutPanel1.Controls.Add(this.btn_THONGKE);
            this.flowLayoutPanel1.Controls.Add(this.btn_NGUOIDUNG);
            this.flowLayoutPanel1.Controls.Add(this.btn_DATA);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 315);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // pnl_Select
            // 
            this.pnl_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
            this.pnl_Select.Location = new System.Drawing.Point(1, 187);
            this.pnl_Select.Name = "pnl_Select";
            this.pnl_Select.Size = new System.Drawing.Size(10, 42);
            this.pnl_Select.TabIndex = 8;
            this.pnl_Select.Visible = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(197, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 1);
            this.panel3.TabIndex = 4;
            // 
            // pnl_NoiDung
            // 
            this.pnl_NoiDung.BackColor = System.Drawing.Color.White;
            this.pnl_NoiDung.Location = new System.Drawing.Point(192, 50);
            this.pnl_NoiDung.Name = "pnl_NoiDung";
            this.pnl_NoiDung.Size = new System.Drawing.Size(894, 561);
            this.pnl_NoiDung.TabIndex = 8;
            // 
            // lbl_NguoiDung
            // 
            this.lbl_NguoiDung.AutoSize = true;
            this.lbl_NguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_NguoiDung.Location = new System.Drawing.Point(221, 26);
            this.lbl_NguoiDung.Name = "lbl_NguoiDung";
            this.lbl_NguoiDung.Size = new System.Drawing.Size(69, 15);
            this.lbl_NguoiDung.TabIndex = 9;
            this.lbl_NguoiDung.Text = "nguoi dung";
            // 
            // gunaTileButton4
            // 
            this.gunaTileButton4.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton4.AnimationSpeed = 0.03F;
            this.gunaTileButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaTileButton4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaTileButton4.ForeColor = System.Drawing.Color.White;
            this.gunaTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaTileButton4.Image")));
            this.gunaTileButton4.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaTileButton4.Location = new System.Drawing.Point(988, 18);
            this.gunaTileButton4.Name = "gunaTileButton4";
            this.gunaTileButton4.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton4.OnHoverImage = null;
            this.gunaTileButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton4.Size = new System.Drawing.Size(30, 26);
            this.gunaTileButton4.TabIndex = 11;
            this.gunaTileButton4.Click += new System.EventHandler(this.gunaTileButton4_Click);
            // 
            // gunaTileButton3
            // 
            this.gunaTileButton3.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton3.AnimationSpeed = 0.03F;
            this.gunaTileButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaTileButton3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaTileButton3.ForeColor = System.Drawing.Color.White;
            this.gunaTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaTileButton3.Image")));
            this.gunaTileButton3.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaTileButton3.Location = new System.Drawing.Point(197, 21);
            this.gunaTileButton3.Name = "gunaTileButton3";
            this.gunaTileButton3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton3.OnHoverImage = null;
            this.gunaTileButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton3.Size = new System.Drawing.Size(23, 24);
            this.gunaTileButton3.TabIndex = 10;
            // 
            // gunaTileButton2
            // 
            this.gunaTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton2.AnimationSpeed = 0.03F;
            this.gunaTileButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaTileButton2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaTileButton2.ForeColor = System.Drawing.Color.White;
            this.gunaTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaTileButton2.Image")));
            this.gunaTileButton2.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaTileButton2.Location = new System.Drawing.Point(1056, 17);
            this.gunaTileButton2.Name = "gunaTileButton2";
            this.gunaTileButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton2.OnHoverImage = null;
            this.gunaTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton2.Size = new System.Drawing.Size(30, 30);
            this.gunaTileButton2.TabIndex = 7;
            this.gunaTileButton2.Click += new System.EventHandler(this.gunaTileButton2_Click);
            // 
            // gunaTileButton1
            // 
            this.gunaTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaTileButton1.AnimationSpeed = 0.03F;
            this.gunaTileButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTileButton1.Image")));
            this.gunaTileButton1.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaTileButton1.Location = new System.Drawing.Point(1024, 17);
            this.gunaTileButton1.Name = "gunaTileButton1";
            this.gunaTileButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaTileButton1.OnHoverImage = null;
            this.gunaTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaTileButton1.Size = new System.Drawing.Size(30, 30);
            this.gunaTileButton1.TabIndex = 6;
            this.gunaTileButton1.Click += new System.EventHandler(this.gunaTileButton1_Click);
            // 
            // btn_HOADON
            // 
            this.btn_HOADON.AnimationHoverSpeed = 0.07F;
            this.btn_HOADON.AnimationSpeed = 0.03F;
            this.btn_HOADON.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_HOADON.BorderColor = System.Drawing.Color.Black;
            this.btn_HOADON.FocusedColor = System.Drawing.Color.Empty;
            this.btn_HOADON.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HOADON.ForeColor = System.Drawing.Color.Black;
            this.btn_HOADON.Image = ((System.Drawing.Image)(resources.GetObject("btn_HOADON.Image")));
            this.btn_HOADON.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_HOADON.Location = new System.Drawing.Point(3, 3);
            this.btn_HOADON.Name = "btn_HOADON";
            this.btn_HOADON.OnHoverBaseColor = System.Drawing.SystemColors.Highlight;
            this.btn_HOADON.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_HOADON.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_HOADON.OnHoverImage = null;
            this.btn_HOADON.OnPressedColor = System.Drawing.Color.Black;
            this.btn_HOADON.Size = new System.Drawing.Size(176, 42);
            this.btn_HOADON.TabIndex = 4;
            this.btn_HOADON.Text = "Hóa Đơn";
            this.btn_HOADON.Click += new System.EventHandler(this.btn_ChucNang_Click);
            // 
            // btn_SANPHAM
            // 
            this.btn_SANPHAM.AnimationHoverSpeed = 0.07F;
            this.btn_SANPHAM.AnimationSpeed = 0.03F;
            this.btn_SANPHAM.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_SANPHAM.BorderColor = System.Drawing.Color.Black;
            this.btn_SANPHAM.FocusedColor = System.Drawing.Color.Empty;
            this.btn_SANPHAM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SANPHAM.ForeColor = System.Drawing.Color.Black;
            this.btn_SANPHAM.Image = ((System.Drawing.Image)(resources.GetObject("btn_SANPHAM.Image")));
            this.btn_SANPHAM.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_SANPHAM.Location = new System.Drawing.Point(3, 51);
            this.btn_SANPHAM.Name = "btn_SANPHAM";
            this.btn_SANPHAM.OnHoverBaseColor = System.Drawing.SystemColors.Highlight;
            this.btn_SANPHAM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_SANPHAM.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_SANPHAM.OnHoverImage = null;
            this.btn_SANPHAM.OnPressedColor = System.Drawing.Color.Black;
            this.btn_SANPHAM.Size = new System.Drawing.Size(176, 42);
            this.btn_SANPHAM.TabIndex = 2;
            this.btn_SANPHAM.Text = "Sản Phẩm";
            this.btn_SANPHAM.Click += new System.EventHandler(this.btn_ChucNang_Click);
            // 
            // btn_KHACHHANG
            // 
            this.btn_KHACHHANG.AnimationHoverSpeed = 0.07F;
            this.btn_KHACHHANG.AnimationSpeed = 0.03F;
            this.btn_KHACHHANG.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_KHACHHANG.BorderColor = System.Drawing.Color.Black;
            this.btn_KHACHHANG.FocusedColor = System.Drawing.Color.Empty;
            this.btn_KHACHHANG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KHACHHANG.ForeColor = System.Drawing.Color.Black;
            this.btn_KHACHHANG.Image = ((System.Drawing.Image)(resources.GetObject("btn_KHACHHANG.Image")));
            this.btn_KHACHHANG.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_KHACHHANG.Location = new System.Drawing.Point(3, 99);
            this.btn_KHACHHANG.Name = "btn_KHACHHANG";
            this.btn_KHACHHANG.OnHoverBaseColor = System.Drawing.SystemColors.Highlight;
            this.btn_KHACHHANG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_KHACHHANG.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_KHACHHANG.OnHoverImage = null;
            this.btn_KHACHHANG.OnPressedColor = System.Drawing.Color.Black;
            this.btn_KHACHHANG.Size = new System.Drawing.Size(176, 42);
            this.btn_KHACHHANG.TabIndex = 10;
            this.btn_KHACHHANG.Text = "Khách Hàng";
            this.btn_KHACHHANG.Click += new System.EventHandler(this.btn_ChucNang_Click);
            // 
            // btn_THONGKE
            // 
            this.btn_THONGKE.AnimationHoverSpeed = 0.07F;
            this.btn_THONGKE.AnimationSpeed = 0.03F;
            this.btn_THONGKE.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_THONGKE.BorderColor = System.Drawing.Color.Black;
            this.btn_THONGKE.FocusedColor = System.Drawing.Color.Empty;
            this.btn_THONGKE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_THONGKE.ForeColor = System.Drawing.Color.Black;
            this.btn_THONGKE.Image = ((System.Drawing.Image)(resources.GetObject("btn_THONGKE.Image")));
            this.btn_THONGKE.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_THONGKE.Location = new System.Drawing.Point(3, 147);
            this.btn_THONGKE.Name = "btn_THONGKE";
            this.btn_THONGKE.OnHoverBaseColor = System.Drawing.SystemColors.Highlight;
            this.btn_THONGKE.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_THONGKE.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_THONGKE.OnHoverImage = null;
            this.btn_THONGKE.OnPressedColor = System.Drawing.Color.Black;
            this.btn_THONGKE.Size = new System.Drawing.Size(176, 42);
            this.btn_THONGKE.TabIndex = 3;
            this.btn_THONGKE.Text = "Thống Kê";
            this.btn_THONGKE.Click += new System.EventHandler(this.btn_ChucNang_Click);
            // 
            // btn_NGUOIDUNG
            // 
            this.btn_NGUOIDUNG.AnimationHoverSpeed = 0.07F;
            this.btn_NGUOIDUNG.AnimationSpeed = 0.03F;
            this.btn_NGUOIDUNG.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_NGUOIDUNG.BorderColor = System.Drawing.Color.Black;
            this.btn_NGUOIDUNG.FocusedColor = System.Drawing.Color.Empty;
            this.btn_NGUOIDUNG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NGUOIDUNG.ForeColor = System.Drawing.Color.Black;
            this.btn_NGUOIDUNG.Image = ((System.Drawing.Image)(resources.GetObject("btn_NGUOIDUNG.Image")));
            this.btn_NGUOIDUNG.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_NGUOIDUNG.Location = new System.Drawing.Point(3, 195);
            this.btn_NGUOIDUNG.Name = "btn_NGUOIDUNG";
            this.btn_NGUOIDUNG.OnHoverBaseColor = System.Drawing.SystemColors.Highlight;
            this.btn_NGUOIDUNG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_NGUOIDUNG.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_NGUOIDUNG.OnHoverImage = null;
            this.btn_NGUOIDUNG.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NGUOIDUNG.Size = new System.Drawing.Size(176, 42);
            this.btn_NGUOIDUNG.TabIndex = 4;
            this.btn_NGUOIDUNG.Text = "Người Dùng";
            this.btn_NGUOIDUNG.Click += new System.EventHandler(this.btn_ChucNang_Click);
            // 
            // btn_DATA
            // 
            this.btn_DATA.AnimationHoverSpeed = 0.07F;
            this.btn_DATA.AnimationSpeed = 0.03F;
            this.btn_DATA.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_DATA.BorderColor = System.Drawing.Color.Black;
            this.btn_DATA.FocusedColor = System.Drawing.Color.Empty;
            this.btn_DATA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DATA.ForeColor = System.Drawing.Color.Black;
            this.btn_DATA.Image = ((System.Drawing.Image)(resources.GetObject("btn_DATA.Image")));
            this.btn_DATA.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_DATA.Location = new System.Drawing.Point(3, 243);
            this.btn_DATA.Name = "btn_DATA";
            this.btn_DATA.OnHoverBaseColor = System.Drawing.SystemColors.Highlight;
            this.btn_DATA.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_DATA.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_DATA.OnHoverImage = null;
            this.btn_DATA.OnPressedColor = System.Drawing.Color.Black;
            this.btn_DATA.Size = new System.Drawing.Size(176, 42);
            this.btn_DATA.TabIndex = 9;
            this.btn_DATA.Text = "Sao Lưu Dữ Liệu";
            this.btn_DATA.Click += new System.EventHandler(this.btn_ChucNang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 618);
            this.Controls.Add(this.gunaTileButton4);
            this.Controls.Add(this.gunaTileButton3);
            this.Controls.Add(this.lbl_NguoiDung);
            this.Controls.Add(this.pnl_NoiDung);
            this.Controls.Add(this.gunaTileButton2);
            this.Controls.Add(this.gunaTileButton1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MainApp";
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaButton btn_HOADON;
        private Guna.UI.WinForms.GunaButton btn_THONGKE;
        private Guna.UI.WinForms.GunaButton btn_SANPHAM;
        private Guna.UI.WinForms.GunaButton btn_NGUOIDUNG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton2;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton1;
        private System.Windows.Forms.Panel pnl_Select;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton3;
        private Guna.UI.WinForms.GunaLabel lbl_NguoiDung;
        private System.Windows.Forms.Panel pnl_NoiDung;
        private Guna.UI.WinForms.GunaButton btn_DATA;
        private Guna.UI.WinForms.GunaButton btn_KHACHHANG;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaTileButton gunaTileButton4;
    }
}