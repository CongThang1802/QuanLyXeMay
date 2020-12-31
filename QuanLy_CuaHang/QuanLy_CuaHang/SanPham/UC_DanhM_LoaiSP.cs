using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.SanPham1
{
    public partial class UC_DanhM_LoaiSP : UserControl
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public UC_DanhM_LoaiSP()
        {
            InitializeComponent();
            Load_Data();
            dgv_DanhMuc.DataSource = dt.DanhMucs;
            dgv_LoaiSP.DataSource = dt.Loai_SPs;
            //dgv_DanhMuc.ColumnHeadersHeight = 24;
            //dgv_DanhMuc.Columns[0].HeaderText = "Mã";
            //dgv_DanhMuc.Columns[1].HeaderText = "Tên";
            //dgv_DanhMuc.Columns[0].Width = 50;

            //dgv_LoaiSP.ColumnHeadersHeight = 24;
            //dgv_LoaiSP.Columns[0].HeaderText = "Mã";
            //dgv_LoaiSP.Columns[1].HeaderText = "Tên";
            //dgv_LoaiSP.Columns[0].Width = 50;
        }

        private void Load_Data()
        {
            try
            {
                dgv_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Get_DanhMucList();
                dgv_LoaiSP.DataSource = Entities_Data.LoaiSP_Data.Get_LoaiSPList();
            }
            catch (Exception) { }
        }

        private void btn_Them_DM_Click(object sender, EventArgs e)
        {
            Dialog.DAL_DanhMuc dAL_Danh = new Dialog.DAL_DanhMuc();
            dAL_Danh.ShowDialog();
            try
            {
                dgv_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Get_DanhMucList();
            }
            catch (Exception) { }
        }

        private void btn_Sua_DM_Click(object sender, EventArgs e)
        {
            Sua_DM();
        }
        private void Sua_DM()
        {
            if (Get_IdDM() != null)
            {
                Dialog.DAL_DanhMuc hangSX = new Dialog.DAL_DanhMuc(int.Parse(Get_IdDM()));
                hangSX.ShowDialog();

                try
                {
                    dgv_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Get_DanhMucList();
                }
                catch (Exception) { }
            }
        }

        private void btn_Xoa_DM_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa giá trị?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (Get_IdDM() != null)
                {
                    Entities_Data.DanhMuc_Data.Delete_DanhMuc(int.Parse(Get_IdDM()));
                    try
                    {
                        dgv_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Get_DanhMucList();
                    }
                    catch (Exception) { }
                }
            }
        }

        private string Get_IdDM()
        {
            if (dgv_DanhMuc.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_DanhMuc.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_DanhMuc.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void btn_LamMoi_DM_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Get_DanhMucList();
            }
            catch (Exception) { }
        }

        private void btn_Them_LSP_Click(object sender, EventArgs e)
        {
            Dialog.DAL_LoaiSP dAL_LoaiSP = new Dialog.DAL_LoaiSP();
            dAL_LoaiSP.ShowDialog();
            try
            {
                dgv_LoaiSP.DataSource = Entities_Data.LoaiSP_Data.Get_LoaiSPList();
            }
            catch (Exception) { }
        }

        private void btn_Sua_LSP_Click(object sender, EventArgs e)
        {
            Sua_LSP();
        }
        private void Sua_LSP()
        {
            if (Get_IdLSP() != null)
            {
                Dialog.DAL_LoaiSP hangSX = new Dialog.DAL_LoaiSP(int.Parse(Get_IdLSP()));
                hangSX.ShowDialog();

                try
                {
                    dgv_LoaiSP.DataSource = Entities_Data.LoaiSP_Data.Get_LoaiSPList();
                }
                catch (Exception) { }
            }
        }

        private void btn_Xoa_LSP_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa giá trị?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (Get_IdLSP() != null)
                {
                    Entities_Data.LoaiSP_Data.Delete_LoaiSP(int.Parse(Get_IdLSP()));
                    try
                    {
                        dgv_LoaiSP.DataSource = Entities_Data.LoaiSP_Data.Get_LoaiSPList();
                    }
                    catch (Exception) { }
                }
            }
        }

        private string Get_IdLSP()
        {
            if (dgv_LoaiSP.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_LoaiSP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_LoaiSP.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void btn_LamMoi_LSP_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_LoaiSP.DataSource = Entities_Data.LoaiSP_Data.Get_LoaiSPList();
            }
            catch (Exception) { }
        }

        private void dgv_LoaiSP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sua_LSP();
        }

        private void dgv_DanhMuc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sua_DM();
        }

        private void btn_Tim_DM_Click(object sender, EventArgs e)
        {
            if (txt_Tim_DM.Text.Trim() != "")
            {
                dgv_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Search_DanhMuc(txt_Tim_DM.Text.ToString());
            }
            else
            {
                try
                {
                    dgv_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Get_DanhMucList();
                }
                catch (Exception) { }
            }
        }

        private void btn_Tim_LSP_Click(object sender, EventArgs e)
        {
            if (txt_Tim_LSP.Text.Trim() != "")
            {
                dgv_LoaiSP.DataSource = Entities_Data.LoaiSP_Data.Search_LoaiSP(txt_Tim_LSP.Text.ToString());
            }
            else
            {
                try
                {
                    dgv_LoaiSP.DataSource = Entities_Data.LoaiSP_Data.Get_LoaiSPList();
                }
                catch (Exception) { }
            }
        }
    }
}
