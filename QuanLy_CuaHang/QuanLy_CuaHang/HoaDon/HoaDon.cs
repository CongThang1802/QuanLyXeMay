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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            string ma = Lap_HD.thongtinHD.ma;
            // TODO: This line of code loads data into the 'DataSetHD.Inhd' table. You can move, or remove it, as needed.
            this.InhdTableAdapter.Fill(this.DataSetHD.Inhd,Convert.ToInt32(ma));
            
            // TODO: This line of code loads data into the 'DataSet1.Inhd' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
