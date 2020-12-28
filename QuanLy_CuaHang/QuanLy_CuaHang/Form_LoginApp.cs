using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang
{
    public partial class Form_LoginApp : Form
    {
        public Form_LoginApp()
        {
            InitializeComponent();
        }
        private bool Auth_Acc(Entities_Data.Get_TKNhanVien_Result tKNhanVien_Result)
        {
            string p = models.MD5_Hash.MD5Hash(txtPassLogin.Text.Trim());
            if (tKNhanVien_Result != null && tKNhanVien_Result.mk_DangNhap.Trim() == p)
                return true;
            return false;
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Entities_Data.Get_TKNhanVien_Result tKNhanVien_Result = Entities_Data.Tai_Khoan_Data.GetNhanVien(Convert.ToInt32(txtManvLogin.Text.Trim()));
            if (Auth_Acc(tKNhanVien_Result))
            {
                this.Visible = false;
                Form_MainApp form_MainApp = new Form_MainApp()
                {
                    tai_khoan_NV = tKNhanVien_Result
                };
                form_MainApp.ShowDialog();
                this.Visible = true;
                lblLoginFail.Visible = false;

            }
            else
            {
                lblLoginFail.Visible = true;
            }
            
        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            GmailXN gmailXN = new GmailXN();
            this.Visible = false;
            gmailXN.ShowDialog();
            this.Visible = true;
        }
    }
}
