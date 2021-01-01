using QuanLy_CuaHang.SanPham.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.SanPham
{
    public partial class UC_GiaSP_TT : UserControl
    {
        public UC_GiaSP_TT()
        {
            InitializeComponent();
            Load_Data();

            dgv_GiaSP.ColumnHeadersHeight = 24;

            dgv_GiaSP.Columns[0].HeaderText = "Mã";
            dgv_GiaSP.Columns[1].HeaderText = "Sản phẩm";
            dgv_GiaSP.Columns[2].HeaderText = "Giá";
            dgv_GiaSP.Columns[3].HeaderText = "Ngày";
        }

        private void Load_Data()
        {
            dgv_GiaSP.DataSource = Entities_Data.GiaSP_Data.Get_GiaSPList();
        }

        private void btn_Sua_GiaSP_Click(object sender, EventArgs e)
        {
            Sua_GiaSP();
        }

        private void Sua_GiaSP()
        {

            if (Get_IdGiaSP() != null)
            {
                Dialog.DAL_GiaSP dAL_GiaSP = GetDAL_GiaSP();
                dAL_GiaSP.ShowDialog();

                Load_Data();
            }
        }

        private DAL_GiaSP GetDAL_GiaSP()
        {
            return new Dialog.DAL_GiaSP(int.Parse(Get_IdGiaSP()));
        }

        private string Get_IdGiaSP()
        {
            if (dgv_GiaSP.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_GiaSP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_GiaSP.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void btn_LamMoi_GiaSP_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_Xoa_GiaSP_Click(object sender, EventArgs e)
        {
            Entities_Data.GiaSP_Data.Delete_GiaSP(int.Parse(Get_IdGiaSP()));
        }

        private void dgv_GiaSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sua_GiaSP();
        }

        private void btn_Them_GiaSP_Click(object sender, EventArgs e)
        {
            Dialog.DAL_GiaSP dAL_GiaSP = new Dialog.DAL_GiaSP();
            dAL_GiaSP.ShowDialog();
            Load_Data();
        }
    }
}
