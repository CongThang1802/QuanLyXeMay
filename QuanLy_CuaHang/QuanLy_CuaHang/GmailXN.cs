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
    public partial class GmailXN : Form
    {
        public GmailXN()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int maxn = 0;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtGmailXN.Text == "")
            {
                MessageBox.Show("Ban chua nhap mail");
                return;
            }
           
        }

        
    }
}
