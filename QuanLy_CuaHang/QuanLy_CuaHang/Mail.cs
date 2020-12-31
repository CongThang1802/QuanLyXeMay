using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang
{
    public partial class Mail : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        Attachment attach = null;
        public Mail()
        {
            InitializeComponent();
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = dt.KhachHangs;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }
        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            String txttendangnhap = "ngoctinmt@gmail.com";
            String txtpass = "12345678t";
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attach != null)
            {
                mess.Attachments.Add(attach);

            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(txttendangnhap, txtpass);
            client.Send(mess);

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            String txttendangnhap = "ngoctinmt@gmail.com";
            //String txtpass = "31121999";
            string txtsubject = " Cảm ơn bạn đã mua sản phẩm";
            string txtMessage = " Hóa Đơn của bạn";


            attach = null;
            try
            {
                FileInfo file = new FileInfo(txtFile.Text);
                attach = new Attachment(txtFile.Text);
            }
            catch
            {

            }

            GuiMail(txttendangnhap, txtMail.Text, txtsubject, txtMessage);
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            txtMail.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
        }
    }
}
