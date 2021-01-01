using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.KhachHang
{
    public partial class UC_TT_KhachHang : UserControl
    {
        public UC_TT_KhachHang()
        {
            InitializeComponent();
            Load_Data();

            dgv_KhachHang.ColumnHeadersHeight = 24;

            dgv_KhachHang.Columns[0].HeaderText = "Mã";
            dgv_KhachHang.Columns[1].HeaderText = "Tên";
            dgv_KhachHang.Columns[2].HeaderText = "Mail";
            dgv_KhachHang.Columns[3].HeaderText = "Điện thoại";

            dgv_KhachHang.Columns[0].Width = 65;
            dgv_KhachHang.Columns[1].Width = 300;
        }

        public void Load_Data()
        {
            dgv_KhachHang.DataSource = Entities_Data.KhachHang_Data.Get_KhachHangList();
        }

        private void btn_LamMoi_KH_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_Xoa_KH_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_KH_Click(object sender, EventArgs e)
        {

        }

        private void dgv_KhachHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
