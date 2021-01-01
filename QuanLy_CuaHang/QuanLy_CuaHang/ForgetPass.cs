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
    public partial class ForgetPass : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
        public int matk;
        public string otp;
        private void btnConf_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text == otp)
            {
                if (txtPassM.Text == "" || txtPassCon.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPassM.Text != txtPassCon.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPassM.Text.Equals(txtPassCon.Text))
                {
                    dt.quenmk(matk, txtPassCon.Text);
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK);

                    this.Hide();
                    Form_LoginApp back = new Form_LoginApp();
                    back.Visible = true;
                }
                else
                {
                    MessageBox.Show("Mã OTP không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
    }
}
