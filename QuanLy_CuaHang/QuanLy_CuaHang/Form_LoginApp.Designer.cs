
namespace QuanLy_CuaHang
{
    partial class Form_LoginApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LoginApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoginFail = new Guna.UI.WinForms.GunaLabel();
            this.lblForget = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMini = new Guna.UI.WinForms.GunaTileButton();
            this.btnExit = new Guna.UI.WinForms.GunaTileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassLogin = new Guna.UI.WinForms.GunaTextBox();
            this.txtManvLogin = new Guna.UI.WinForms.GunaTextBox();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 17);
            this.panel1.TabIndex = 6;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-147, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLoginFail);
            this.panel2.Controls.Add(this.lblForget);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnMini);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPassLogin);
            this.panel2.Controls.Add(this.txtManvLogin);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Location = new System.Drawing.Point(302, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 318);
            this.panel2.TabIndex = 11;
            // 
            // lblLoginFail
            // 
            this.lblLoginFail.AutoSize = true;
            this.lblLoginFail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginFail.ForeColor = System.Drawing.Color.Red;
            this.lblLoginFail.Location = new System.Drawing.Point(93, 248);
            this.lblLoginFail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginFail.Name = "lblLoginFail";
            this.lblLoginFail.Size = new System.Drawing.Size(222, 16);
            this.lblLoginFail.TabIndex = 20;
            this.lblLoginFail.Text = "Tài khoản hoặc mật khẩu không đúng";
            this.lblLoginFail.Visible = false;
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForget.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblForget.Location = new System.Drawing.Point(130, 276);
            this.lblForget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(126, 22);
            this.lblForget.TabIndex = 19;
            this.lblForget.Text = "Quên mật khẩu";
            this.lblForget.Click += new System.EventHandler(this.lblForget_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnMini
            // 
            this.btnMini.AnimationHoverSpeed = 0.07F;
            this.btnMini.AnimationSpeed = 0.03F;
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BaseColor = System.Drawing.Color.Transparent;
            this.btnMini.BorderColor = System.Drawing.Color.Black;
            this.btnMini.FocusedColor = System.Drawing.Color.Empty;
            this.btnMini.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageSize = new System.Drawing.Size(28, 28);
            this.btnMini.Location = new System.Drawing.Point(271, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMini.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMini.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMini.OnHoverImage = null;
            this.btnMini.OnPressedColor = System.Drawing.Color.Black;
            this.btnMini.Size = new System.Drawing.Size(30, 30);
            this.btnMini.TabIndex = 17;
            this.btnMini.Click += new System.EventHandler(this.gunaTileButton2_Click);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(28, 28);
            this.btnExit.Location = new System.Drawing.Point(304, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 16;
            this.btnExit.Click += new System.EventHandler(this.gunaTileButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đăng Nhập";
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtPassLogin.BaseColor = System.Drawing.Color.White;
            this.txtPassLogin.BorderColor = System.Drawing.Color.Silver;
            this.txtPassLogin.BorderSize = 1;
            this.txtPassLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassLogin.Location = new System.Drawing.Point(85, 160);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.PasswordChar = '●';
            this.txtPassLogin.Radius = 12;
            this.txtPassLogin.Size = new System.Drawing.Size(216, 34);
            this.txtPassLogin.TabIndex = 12;
            this.txtPassLogin.Text = "123456";
            this.txtPassLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassLogin.UseSystemPasswordChar = true;
            // 
            // txtManvLogin
            // 
            this.txtManvLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtManvLogin.BaseColor = System.Drawing.Color.White;
            this.txtManvLogin.BorderColor = System.Drawing.Color.Silver;
            this.txtManvLogin.BorderSize = 1;
            this.txtManvLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManvLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtManvLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtManvLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtManvLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtManvLogin.Location = new System.Drawing.Point(85, 124);
            this.txtManvLogin.Name = "txtManvLogin";
            this.txtManvLogin.PasswordChar = '\0';
            this.txtManvLogin.Radius = 12;
            this.txtManvLogin.Size = new System.Drawing.Size(216, 34);
            this.txtManvLogin.TabIndex = 11;
            this.txtManvLogin.Text = "6000";
            this.txtManvLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.BorderSize = 1;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogin.Location = new System.Drawing.Point(85, 207);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.Radius = 12;
            this.btnLogin.Size = new System.Drawing.Size(216, 30);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Form_LoginApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 335);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_LoginApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTileButton btnMini;
        private Guna.UI.WinForms.GunaTileButton btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtPassLogin;
        private Guna.UI.WinForms.GunaTextBox txtManvLogin;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lblForget;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLabel lblLoginFail;
    }
}

