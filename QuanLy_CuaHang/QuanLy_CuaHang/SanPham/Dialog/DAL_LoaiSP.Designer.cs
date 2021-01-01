
namespace QuanLy_CuaHang.SanPham1.Dialog
{
    partial class DAL_LoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAL_LoaiSP));
            this.btn_Huy = new Guna.UI.WinForms.GunaButton();
            this.btn_Luu = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenLoai = new Guna.UI.WinForms.GunaTextBox();
            this.txt_MaLoai = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.AnimationHoverSpeed = 0.07F;
            this.btn_Huy.AnimationSpeed = 0.03F;
            this.btn_Huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_Huy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Huy.BorderColor = System.Drawing.Color.Black;
            this.btn_Huy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Huy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Huy.Location = new System.Drawing.Point(209, 118);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Huy.OnHoverImage = null;
            this.btn_Huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Huy.Radius = 12;
            this.btn_Huy.Size = new System.Drawing.Size(69, 30);
            this.btn_Huy.TabIndex = 23;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.AnimationHoverSpeed = 0.07F;
            this.btn_Luu.AnimationSpeed = 0.03F;
            this.btn_Luu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Luu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Luu.BorderColor = System.Drawing.Color.Black;
            this.btn_Luu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Luu.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Luu.Location = new System.Drawing.Point(134, 118);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Luu.OnHoverImage = null;
            this.btn_Luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Luu.Radius = 12;
            this.btn_Luu.Size = new System.Drawing.Size(69, 30);
            this.btn_Luu.TabIndex = 22;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã loại";
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.BackColor = System.Drawing.Color.Transparent;
            this.txt_TenLoai.BaseColor = System.Drawing.Color.White;
            this.txt_TenLoai.BorderColor = System.Drawing.Color.Silver;
            this.txt_TenLoai.BorderSize = 1;
            this.txt_TenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenLoai.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TenLoai.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TenLoai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenLoai.Location = new System.Drawing.Point(99, 60);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.PasswordChar = '\0';
            this.txt_TenLoai.Radius = 12;
            this.txt_TenLoai.Size = new System.Drawing.Size(160, 30);
            this.txt_TenLoai.TabIndex = 19;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.BackColor = System.Drawing.Color.Transparent;
            this.txt_MaLoai.BaseColor = System.Drawing.Color.White;
            this.txt_MaLoai.BorderColor = System.Drawing.Color.Silver;
            this.txt_MaLoai.BorderSize = 1;
            this.txt_MaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaLoai.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaLoai.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaLoai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaLoai.Location = new System.Drawing.Point(99, 24);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.PasswordChar = '\0';
            this.txt_MaLoai.Radius = 12;
            this.txt_MaLoai.Size = new System.Drawing.Size(160, 30);
            this.txt_MaLoai.TabIndex = 18;
            // 
            // DAL_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 172);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenLoai);
            this.Controls.Add(this.txt_MaLoai);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DAL_LoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin loại sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_Huy;
        private Guna.UI.WinForms.GunaButton btn_Luu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_TenLoai;
        private Guna.UI.WinForms.GunaTextBox txt_MaLoai;
    }
}