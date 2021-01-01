
namespace QuanLy_CuaHang.SanPham1.Dialog
{
    partial class DAL_DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAL_DanhMuc));
            this.btn_Huy = new Guna.UI.WinForms.GunaButton();
            this.btn_Luu = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenDM = new Guna.UI.WinForms.GunaTextBox();
            this.txt_MaDM = new Guna.UI.WinForms.GunaTextBox();
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
            this.btn_Huy.Location = new System.Drawing.Point(208, 121);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Huy.OnHoverImage = null;
            this.btn_Huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Huy.Radius = 12;
            this.btn_Huy.Size = new System.Drawing.Size(69, 30);
            this.btn_Huy.TabIndex = 17;
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
            this.btn_Luu.Location = new System.Drawing.Point(133, 121);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Luu.OnHoverImage = null;
            this.btn_Luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Luu.Radius = 12;
            this.btn_Luu.Size = new System.Drawing.Size(69, 30);
            this.btn_Luu.TabIndex = 16;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên hãng danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã hãng danh mục";
            // 
            // txt_TenDM
            // 
            this.txt_TenDM.BackColor = System.Drawing.Color.Transparent;
            this.txt_TenDM.BaseColor = System.Drawing.Color.White;
            this.txt_TenDM.BorderColor = System.Drawing.Color.Silver;
            this.txt_TenDM.BorderSize = 1;
            this.txt_TenDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenDM.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TenDM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TenDM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TenDM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenDM.Location = new System.Drawing.Point(122, 63);
            this.txt_TenDM.Name = "txt_TenDM";
            this.txt_TenDM.PasswordChar = '\0';
            this.txt_TenDM.Radius = 12;
            this.txt_TenDM.Size = new System.Drawing.Size(160, 30);
            this.txt_TenDM.TabIndex = 13;
            // 
            // txt_MaDM
            // 
            this.txt_MaDM.BackColor = System.Drawing.Color.Transparent;
            this.txt_MaDM.BaseColor = System.Drawing.Color.White;
            this.txt_MaDM.BorderColor = System.Drawing.Color.Silver;
            this.txt_MaDM.BorderSize = 1;
            this.txt_MaDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaDM.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaDM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaDM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaDM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaDM.Location = new System.Drawing.Point(122, 27);
            this.txt_MaDM.Name = "txt_MaDM";
            this.txt_MaDM.PasswordChar = '\0';
            this.txt_MaDM.Radius = 12;
            this.txt_MaDM.Size = new System.Drawing.Size(160, 30);
            this.txt_MaDM.TabIndex = 12;
            // 
            // DAL_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 172);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenDM);
            this.Controls.Add(this.txt_MaDM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DAL_DanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin danh mục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_Huy;
        private Guna.UI.WinForms.GunaButton btn_Luu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_TenDM;
        private Guna.UI.WinForms.GunaTextBox txt_MaDM;
    }
}