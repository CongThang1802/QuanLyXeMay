using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.QL_NguoiDung
{
    public partial class UC_QLNguoiDung : UserControl
    {
        public UC_QLNguoiDung()
        {
            InitializeComponent();
            Load_Data();

            dgv_TTNhanVien.ColumnHeadersHeight = 24;

            //dgv_TTNhanVien.Columns[0].HeaderText = "Mã";
            //dgv_TTNhanVien.Columns[1].HeaderText = "Họ tên";
            //dgv_TTNhanVien.Columns[2].HeaderText = "Mail";
            //dgv_TTNhanVien.Columns[3].HeaderText = "Số điện thoại";

            //dgv_TTNhanVien.Columns[0].Width = 50;
            //dgv_TTNhanVien.Columns[3].Width = 100;

            dgv_TTNhanVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 128, 235);
            dgv_TTNhanVien.EnableHeadersVisualStyles = false;
        }

        private void Load_Data()
        {
            dgv_TTNhanVien.DataSource = Entities_Data.NguoiDung_Data.Get_NhanVienList();
        }

        private void btn_ThemNguoiDung_Click(object sender, EventArgs e)
        {
            Form_ThemNguoiDung form_ThemNguoiDung = new Form_ThemNguoiDung();
            form_ThemNguoiDung.ShowDialog();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
