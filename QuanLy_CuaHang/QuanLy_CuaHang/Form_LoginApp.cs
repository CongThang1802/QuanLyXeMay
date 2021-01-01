using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang
{
    public partial class Form_LoginApp : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public class TTNV
        {
            static public int MaNV ;
        }
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

        public string MaHoa(string txt)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            txt = sb.ToString();
            return txt;
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //Entities_Data.Get_TKNhanVien_Result tKNhanVien_Result = Entities_Data.Tai_Khoan_Data.GetNhanVien(Convert.ToInt32(txtManvLogin.Text.Trim()));
            //if (Auth_Acc(tKNhanVien_Result))
            //{
            //    this.Visible = false;
            //    Form_MainApp form_MainApp = new Form_MainApp()
            //    {
            //        tai_khoan_NV = tKNhanVien_Result
            //    };
            //    form_MainApp.ShowDialog();
            //    this.Visible = true;
            //    lblLoginFail.Visible = false;

            //}
            //else
            //{
            //    lblLoginFail.Visible = true;
            //}

            //NhanVien nv = dt.NhanViens.Where(s => s.ma_NV ==Convert.ToInt32(txtManvLogin.Text.Trim())).Where(s => s.mk_DangNhap == MaHoa(txtPassLogin.Text.ToString())).FirstOrDefault();
            Entities_Data.Get_TKNhanVien_Result tKNhanVien_Result = Entities_Data.Tai_Khoan_Data.GetNhanVien(Convert.ToInt32(txtManvLogin.Text.Trim()));
            if (tKNhanVien_Result == null)
            {
                lblLoginFail.Visible = true;
            }
            else
            {

                TTNV.MaNV = tKNhanVien_Result.ma_NV;

                Form_MainApp f1 = new Form_MainApp();
                this.Hide();

                f1.Show();
            }

        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
