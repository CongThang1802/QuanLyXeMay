using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.HoaDon
{
    public partial class ViewTTHD : Form
    {
        public ViewTTHD()
        {
            InitializeComponent();
        }

        private void ViewTTHD_Load(object sender, EventArgs e)
        {
            string ma = HD_BanHang.thongtinHD.ma;
            // TODO: This line of code loads data into the 'DataSetHD.Inhd' table. You can move, or remove it, as needed.
            this.InhdTableAdapter.Fill(this.DataSetHD.Inhd, Convert.ToInt32(ma));

            this.reportViewer1.RefreshReport();
        }
    }
}
