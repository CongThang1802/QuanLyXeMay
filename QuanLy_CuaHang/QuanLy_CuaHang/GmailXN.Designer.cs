
namespace QuanLy_CuaHang
{
    partial class GmailXN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GmailXN));
            this.txtMNVxN = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtGmailXN = new Guna.UI.WinForms.GunaTextBox();
            this.btnSend = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // txtMNVxN
            // 
            this.txtMNVxN.BaseColor = System.Drawing.Color.White;
            this.txtMNVxN.BorderColor = System.Drawing.Color.Silver;
            this.txtMNVxN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMNVxN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMNVxN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMNVxN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMNVxN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMNVxN.Location = new System.Drawing.Point(235, 44);
            this.txtMNVxN.Name = "txtMNVxN";
            this.txtMNVxN.PasswordChar = '\0';
            this.txtMNVxN.Size = new System.Drawing.Size(334, 36);
            this.txtMNVxN.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(40, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(170, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Nhập mã nhân viên:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(40, 159);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(108, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Nhập gmail:";
            // 
            // txtGmailXN
            // 
            this.txtGmailXN.BaseColor = System.Drawing.Color.White;
            this.txtGmailXN.BorderColor = System.Drawing.Color.Silver;
            this.txtGmailXN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmailXN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGmailXN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGmailXN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGmailXN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGmailXN.Location = new System.Drawing.Point(235, 148);
            this.txtGmailXN.Name = "txtGmailXN";
            this.txtGmailXN.PasswordChar = '\0';
            this.txtGmailXN.Size = new System.Drawing.Size(337, 36);
            this.txtGmailXN.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend.Location = new System.Drawing.Point(288, 224);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Size = new System.Drawing.Size(140, 42);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // GmailXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 295);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtGmailXN);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtMNVxN);
            this.Name = "GmailXN";
            this.Text = "GmailXN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtMNVxN;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtGmailXN;
        private Guna.UI.WinForms.GunaButton btnSend;
    }
}