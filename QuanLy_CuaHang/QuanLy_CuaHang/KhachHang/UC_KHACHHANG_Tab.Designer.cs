
namespace QuanLy_CuaHang.KhachHang
{
    partial class UC_KHACHHANG_Tab
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
            this.tab_QL_KhachHang = new System.Windows.Forms.TabControl();
            this.tab_TT_KhachHang = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_QL_KhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_QL_KhachHang
            // 
            this.tab_QL_KhachHang.Controls.Add(this.tab_TT_KhachHang);
            this.tab_QL_KhachHang.Controls.Add(this.tabPage2);
            this.tab_QL_KhachHang.ItemSize = new System.Drawing.Size(58, 30);
            this.tab_QL_KhachHang.Location = new System.Drawing.Point(0, 0);
            this.tab_QL_KhachHang.Name = "tab_QL_KhachHang";
            this.tab_QL_KhachHang.SelectedIndex = 0;
            this.tab_QL_KhachHang.Size = new System.Drawing.Size(894, 561);
            this.tab_QL_KhachHang.TabIndex = 1;
            this.tab_QL_KhachHang.Click += new System.EventHandler(this.tab_QL_KhachHang_Click);
            // 
            // tab_TT_KhachHang
            // 
            this.tab_TT_KhachHang.Location = new System.Drawing.Point(4, 34);
            this.tab_TT_KhachHang.Name = "tab_TT_KhachHang";
            this.tab_TT_KhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TT_KhachHang.Size = new System.Drawing.Size(886, 523);
            this.tab_TT_KhachHang.TabIndex = 0;
            this.tab_TT_KhachHang.Text = "Thông tin khách hàng";
            this.tab_TT_KhachHang.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UC_KHACHHANG_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tab_QL_KhachHang);
            this.Name = "UC_KHACHHANG_Tab";
            this.Size = new System.Drawing.Size(894, 561);
            this.tab_QL_KhachHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_QL_KhachHang;
        private System.Windows.Forms.TabPage tab_TT_KhachHang;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
