
namespace QuanLy_CuaHang
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaXN = new Guna.UI.WinForms.GunaTextBox();
            this.btnConf = new Guna.UI.WinForms.GunaButton();
            this.txtPassM = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassCon = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(65, 24);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(178, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Mã xác nhận sẽ gửi tới mail bạn.";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(8, 46);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(78, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Mã xác nhận:";
            // 
            // txtMaXN
            // 
            this.txtMaXN.BackColor = System.Drawing.Color.Transparent;
            this.txtMaXN.BaseColor = System.Drawing.Color.White;
            this.txtMaXN.BorderColor = System.Drawing.Color.Silver;
            this.txtMaXN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaXN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaXN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaXN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaXN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaXN.Location = new System.Drawing.Point(11, 64);
            this.txtMaXN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.PasswordChar = '\0';
            this.txtMaXN.Radius = 10;
            this.txtMaXN.Size = new System.Drawing.Size(253, 41);
            this.txtMaXN.TabIndex = 4;
            // 
            // btnConf
            // 
            this.btnConf.AnimationHoverSpeed = 0.07F;
            this.btnConf.AnimationSpeed = 0.03F;
            this.btnConf.BackColor = System.Drawing.Color.Transparent;
            this.btnConf.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnConf.BorderColor = System.Drawing.Color.Black;
            this.btnConf.FocusedColor = System.Drawing.Color.Empty;
            this.btnConf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConf.ForeColor = System.Drawing.Color.White;
            this.btnConf.Image = ((System.Drawing.Image)(resources.GetObject("btnConf.Image")));
            this.btnConf.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConf.Location = new System.Drawing.Point(68, 295);
            this.btnConf.Margin = new System.Windows.Forms.Padding(2);
            this.btnConf.Name = "btnConf";
            this.btnConf.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConf.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConf.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConf.OnHoverImage = null;
            this.btnConf.OnPressedColor = System.Drawing.Color.Black;
            this.btnConf.Radius = 10;
            this.btnConf.Size = new System.Drawing.Size(107, 32);
            this.btnConf.TabIndex = 7;
            this.btnConf.Text = "Cập Nhật";
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // txtPassM
            // 
            this.txtPassM.BackColor = System.Drawing.Color.Transparent;
            this.txtPassM.BaseColor = System.Drawing.Color.White;
            this.txtPassM.BorderColor = System.Drawing.Color.Silver;
            this.txtPassM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassM.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassM.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassM.Location = new System.Drawing.Point(14, 155);
            this.txtPassM.Name = "txtPassM";
            this.txtPassM.PasswordChar = '\0';
            this.txtPassM.Radius = 10;
            this.txtPassM.Size = new System.Drawing.Size(250, 39);
            this.txtPassM.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật Khẩu Mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập Lại Mật Khẩu:";
            // 
            // txtPassCon
            // 
            this.txtPassCon.BackColor = System.Drawing.Color.Transparent;
            this.txtPassCon.BaseColor = System.Drawing.Color.White;
            this.txtPassCon.BorderColor = System.Drawing.Color.Silver;
            this.txtPassCon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassCon.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassCon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassCon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassCon.Location = new System.Drawing.Point(14, 240);
            this.txtPassCon.Name = "txtPassCon";
            this.txtPassCon.PasswordChar = '\0';
            this.txtPassCon.Radius = 10;
            this.txtPassCon.Size = new System.Drawing.Size(250, 39);
            this.txtPassCon.TabIndex = 15;
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 377);
            this.Controls.Add(this.txtPassCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassM);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.txtMaXN);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtMaXN;
        private Guna.UI.WinForms.GunaButton btnConf;
        private Guna.UI.WinForms.GunaTextBox txtPassM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtPassCon;
    }
}