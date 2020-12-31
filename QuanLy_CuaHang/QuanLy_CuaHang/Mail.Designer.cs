
namespace QuanLy_CuaHang
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFile = new Guna.UI.WinForms.GunaTextBox();
            this.txtMail = new Guna.UI.WinForms.GunaTextBox();
            this.btnSend = new Guna.UI.WinForms.GunaButton();
            this.btnAttach = new Guna.UI.WinForms.GunaButton();
            this.dgvKH = new Guna.UI.WinForms.GunaDataGridView();
            this.ma_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_hk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.Transparent;
            this.txtFile.BaseColor = System.Drawing.Color.White;
            this.txtFile.BorderColor = System.Drawing.Color.Silver;
            this.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFile.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFile.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFile.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFile.Location = new System.Drawing.Point(134, 43);
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.Radius = 10;
            this.txtFile.Size = new System.Drawing.Size(160, 39);
            this.txtFile.TabIndex = 0;
            this.txtFile.Text = "File";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Transparent;
            this.txtMail.BaseColor = System.Drawing.Color.White;
            this.txtMail.BorderColor = System.Drawing.Color.Silver;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMail.Location = new System.Drawing.Point(134, 107);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.Radius = 10;
            this.txtMail.Size = new System.Drawing.Size(160, 42);
            this.txtMail.TabIndex = 1;
            this.txtMail.Text = "Mail";
            // 
            // btnSend
            // 
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend.Location = new System.Drawing.Point(393, 107);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Radius = 10;
            this.btnSend.Size = new System.Drawing.Size(129, 42);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.AnimationHoverSpeed = 0.07F;
            this.btnAttach.AnimationSpeed = 0.03F;
            this.btnAttach.BackColor = System.Drawing.Color.Transparent;
            this.btnAttach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAttach.BorderColor = System.Drawing.Color.Black;
            this.btnAttach.FocusedColor = System.Drawing.Color.Empty;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAttach.Location = new System.Drawing.Point(393, 43);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAttach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAttach.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAttach.OnHoverImage = null;
            this.btnAttach.OnPressedColor = System.Drawing.Color.Black;
            this.btnAttach.Radius = 10;
            this.btnAttach.Size = new System.Drawing.Size(129, 39);
            this.btnAttach.TabIndex = 2;
            this.btnAttach.Text = "Attach";
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToDeleteRows = false;
            this.dgvKH.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_kh,
            this.ten_hk,
            this.mail_kh,
            this.sdt_kh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.EnableHeadersVisualStyles = false;
            this.dgvKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.Location = new System.Drawing.Point(-2, 168);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(666, 206);
            this.dgvKH.TabIndex = 4;
            this.dgvKH.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvKH.ThemeStyle.ReadOnly = true;
            this.dgvKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentClick);
            // 
            // ma_kh
            // 
            this.ma_kh.DataPropertyName = "ma_kh";
            this.ma_kh.HeaderText = "Mã Khách Hàng";
            this.ma_kh.Name = "ma_kh";
            this.ma_kh.ReadOnly = true;
            // 
            // ten_hk
            // 
            this.ten_hk.DataPropertyName = "ten_hk";
            this.ten_hk.HeaderText = "Tên Khách Hàng";
            this.ten_hk.Name = "ten_hk";
            this.ten_hk.ReadOnly = true;
            // 
            // mail_kh
            // 
            this.mail_kh.DataPropertyName = "mail_kh";
            this.mail_kh.HeaderText = "Mail";
            this.mail_kh.Name = "mail_kh";
            this.mail_kh.ReadOnly = true;
            // 
            // sdt_kh
            // 
            this.sdt_kh.DataPropertyName = "sdt_kh";
            this.sdt_kh.HeaderText = "Số Điện Thoại";
            this.sdt_kh.Name = "sdt_kh";
            this.sdt_kh.ReadOnly = true;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 372);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtFile);
            this.Name = "Mail";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtFile;
        private Guna.UI.WinForms.GunaTextBox txtMail;
        private Guna.UI.WinForms.GunaButton btnAttach;
        private Guna.UI.WinForms.GunaButton btnSend;
        private Guna.UI.WinForms.GunaDataGridView dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_hk;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt_kh;
    }
}