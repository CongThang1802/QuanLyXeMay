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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_MainApp form_MainApp = new Form_MainApp();
            form_MainApp.ShowDialog();
            this.Visible = true;
        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
