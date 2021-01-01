
namespace QuanLy_CuaHang.SanPham1
{
    partial class UC_SanPham_Tab
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
            this.tab_QL_SanPham = new System.Windows.Forms.TabControl();
            this.tab_SanPham = new System.Windows.Forms.TabPage();
            this.tab_GiaSP = new System.Windows.Forms.TabPage();
            this.tab_HangSX_NCC = new System.Windows.Forms.TabPage();
            this.tab_DanhM_LoaiSP = new System.Windows.Forms.TabPage();
            this.tab_QL_SanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_QL_SanPham
            // 
            this.tab_QL_SanPham.Controls.Add(this.tab_SanPham);
            this.tab_QL_SanPham.Controls.Add(this.tab_GiaSP);
            this.tab_QL_SanPham.Controls.Add(this.tab_HangSX_NCC);
            this.tab_QL_SanPham.Controls.Add(this.tab_DanhM_LoaiSP);
            this.tab_QL_SanPham.ItemSize = new System.Drawing.Size(58, 30);
            this.tab_QL_SanPham.Location = new System.Drawing.Point(0, 0);
            this.tab_QL_SanPham.Name = "tab_QL_SanPham";
            this.tab_QL_SanPham.SelectedIndex = 0;
            this.tab_QL_SanPham.Size = new System.Drawing.Size(894, 561);
            this.tab_QL_SanPham.TabIndex = 2;
            this.tab_QL_SanPham.Click += new System.EventHandler(this.tab_Control_Click);
            // 
            // tab_SanPham
            // 
            this.tab_SanPham.Location = new System.Drawing.Point(4, 34);
            this.tab_SanPham.Name = "tab_SanPham";
            this.tab_SanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SanPham.Size = new System.Drawing.Size(886, 523);
            this.tab_SanPham.TabIndex = 0;
            this.tab_SanPham.Text = "Sản phẩm";
            this.tab_SanPham.UseVisualStyleBackColor = true;
            // 
            // tab_GiaSP
            // 
            this.tab_GiaSP.Location = new System.Drawing.Point(4, 34);
            this.tab_GiaSP.Name = "tab_GiaSP";
            this.tab_GiaSP.Padding = new System.Windows.Forms.Padding(3);
            this.tab_GiaSP.Size = new System.Drawing.Size(886, 523);
            this.tab_GiaSP.TabIndex = 1;
            this.tab_GiaSP.Text = "Giá sản phẩm";
            this.tab_GiaSP.UseVisualStyleBackColor = true;
            // 
            // tab_HangSX_NCC
            // 
            this.tab_HangSX_NCC.Location = new System.Drawing.Point(4, 34);
            this.tab_HangSX_NCC.Name = "tab_HangSX_NCC";
            this.tab_HangSX_NCC.Padding = new System.Windows.Forms.Padding(3);
            this.tab_HangSX_NCC.Size = new System.Drawing.Size(886, 523);
            this.tab_HangSX_NCC.TabIndex = 2;
            this.tab_HangSX_NCC.Text = "Hãng sản xuất & Nhà cung cấp";
            this.tab_HangSX_NCC.UseVisualStyleBackColor = true;
            // 
            // tab_DanhM_LoaiSP
            // 
            this.tab_DanhM_LoaiSP.Location = new System.Drawing.Point(4, 34);
            this.tab_DanhM_LoaiSP.Name = "tab_DanhM_LoaiSP";
            this.tab_DanhM_LoaiSP.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DanhM_LoaiSP.Size = new System.Drawing.Size(886, 523);
            this.tab_DanhM_LoaiSP.TabIndex = 3;
            this.tab_DanhM_LoaiSP.Text = "Danh muc & Loại sản phẩm";
            this.tab_DanhM_LoaiSP.UseVisualStyleBackColor = true;
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tab_QL_SanPham);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(894, 561);
            this.tab_QL_SanPham.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_QL_SanPham;
        private System.Windows.Forms.TabPage tab_SanPham;
        private System.Windows.Forms.TabPage tab_GiaSP;
        private System.Windows.Forms.TabPage tab_HangSX_NCC;
        private System.Windows.Forms.TabPage tab_DanhM_LoaiSP;
        private System.Windows.Forms.TabPage tab_DanhMuc;
    }
}
