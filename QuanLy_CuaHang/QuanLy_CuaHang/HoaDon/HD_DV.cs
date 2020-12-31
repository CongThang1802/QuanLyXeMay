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
    public partial class HD_DV : UserControl
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public HD_DV()
        {
            InitializeComponent();
        }

        private void HD_DV_Load(object sender, EventArgs e)
        {
            dgvHDDV.DataSource = dt.hd_dv();

            //txtIDDV.DataBindings.Clear();
            //txtIDDV.DataBindings.Add("text", dgvHDDV.DataSource, "Ma_hddv");

            //txtTenDV.DataBindings.Clear();
            //txtTenDV.DataBindings.Add("text", dgvHDDV.DataSource, "Ten_dv");

            //txtTenKhDV.DataBindings.Clear();
            //txtTenKhDV.DataBindings.Add("text", dgvHDDV.DataSource, "ten_hk");

            //txtTenNVDV.DataBindings.Clear();
            //txtTenNVDV.DataBindings.Add("text", dgvHDDV.DataSource, "ten_nv");

            //txtTongTienDV.DataBindings.Clear();
            //txtTongTienDV.DataBindings.Add("text", dgvHDDV.DataSource, "tongtien_dv");
        }

        private void btn_Tim_HDDV_Click(object sender, EventArgs e)
        {
            if (txt_Tim_HDDV.Text.Trim() == "")
            {
                dgvHDDV.DataSource = dt.hd();
            }
            dgvHDDV.AutoGenerateColumns = false;
            dgvHDDV.DataSource = dt.searh_hddv(txt_Tim_HDDV.Text);

        }

        private void dgvHDDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDDV.Enabled = false;
            txtTenDV.Enabled = false;
            txtTenKhDV.Enabled = false;
            txtTenNVDV.Enabled = false;
            txtTongTienDV.Enabled = false;
            int i;
            i = dgvHDDV.CurrentRow.Index;
            txtIDDV.Text = dgvHDDV.Rows[i].Cells[0].Value.ToString();
            txtTenDV.Text = dgvHDDV.Rows[i].Cells[1].Value.ToString();
            txtTenKhDV.Text = dgvHDDV.Rows[i].Cells[2].Value.ToString();
            txtTenNVDV.Text = dgvHDDV.Rows[i].Cells[3].Value.ToString();
            txtTongTienDV.Text = dgvHDDV.Rows[i].Cells[4].Value.ToString();
        }
    }
}
