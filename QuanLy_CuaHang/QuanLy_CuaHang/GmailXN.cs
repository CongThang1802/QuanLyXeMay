using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang
{
    public partial class GmailXN : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public GmailXN()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int maxn = 0;

        private void btnSend_Click(object sender, EventArgs e)
        {
            DialogResult dtr = MessageBox.Show("Bạn Có Chắc Muốn Đổi Mật Khẩu Không", "Thông báo", MessageBoxButtons.OKCancel);
            if (dtr == DialogResult.OK)
            {
                var rda = dt.NhanViens.Where(s => s.ma_NV == Convert.ToInt32(txtMNVxN.Text.Trim())).Where(s => s.mail_NV == txtGmailXN.Text.Trim()).FirstOrDefault();
                if (rda == null)
                {
                    MessageBox.Show("Không có tài khoản này!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string bodyemail = "Xin Chào " + rda.ten_NV + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                                    + "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
                                    + "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
                                    + "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
                                    + "\t\t=> Mã Xác Minh Của Bạn Là: " + rda.mk_DangNhap.Remove(6, 26)
                                    + "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu";
                    try
                    {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("ngoctinmt@gmail.com");
                        mail.To.Add(rda.mail_NV);
                        mail.Subject = "Đưa những chiếc xe về ngôi nhà của bạn";
                        mail.Body = bodyemail;
                        SmtpClient smptClient = new SmtpClient();
                        smptClient.Host = "smtp.gmail.com";
                        System.Net.NetworkCredential credential = new NetworkCredential();
                        credential.UserName = "ngoctinmt@gmail.com";
                        credential.Password = "12345678t";
                        smptClient.Credentials = credential;
                        smptClient.Port = 587;
                        smptClient.EnableSsl = true;
                        smptClient.Send(mail);
                        MessageBox.Show("Đã gửi mã xác minh về Email Mời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
                        ForgetPass f = new ForgetPass();
                        this.Hide();
                        f.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form_LoginApp f1 = new Form_LoginApp();
            this.Hide();
            f1.Show();
        }
    }
}
