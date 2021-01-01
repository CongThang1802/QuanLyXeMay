using Entities_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.HoaDon
{
    public partial class HD_BanHang : UserControl
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();

        public HD_BanHang()
        {
            InitializeComponent();
            

        }

        public class thongtinHD
        {
            public static string ma;

        }

        private void HD_BanHang_Load(object sender, EventArgs e)
        {
            dgv_HD.DataSource = dt.hd();
            //txtID.DataBindings.Clear();
            //txtID.DataBindings.Add("text", dgv_HD.DataSource, "Ma_hd");

            //txtTenNV.DataBindings.Clear();
            //txtTenNV.DataBindings.Add("text", dgv_HD.DataSource, "Ten_nv");

            //txtTenKh.DataBindings.Clear();
            //txtTenKh.DataBindings.Add("text", dgv_HD.DataSource, "ten_hk");

            //dateHD.DataBindings.Clear();
            //dateHD.DataBindings.Add("text", dgv_HD.DataSource, "ngaylap_hd");

            //txtTongTien.DataBindings.Clear();
            //txtTongTien.DataBindings.Add("text", dgv_HD.DataSource, "thanhtien");


            //cbTenNv.DisplayMember = "TEN_nv";
            //cbTenNv.ValueMember = "MA_nv";
            //cbTenNv.DataSource = dt.NhanViens.ToList();


            //cbTenKH.DisplayMember = "TEN_HK";
            //cbTenKH.ValueMember = "MA_KH";
            //cbTenKH.DataSource = dt.KhachHangs.ToList();

            dgv_HD.AutoGenerateColumns = false;
        }


        Boolean add = false;
        private void btn_Them_HD_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenNV.Text = "";
            txtTenKh.Text = "";
            dateHD.Text = "";
            txtTongTien.Text = "0";
            txtTenNV.Focus();


            txtID.Enabled = false;
            txtTenNV.Enabled = true;
            txtTenKh.Enabled = true;
            dateHD.Enabled = true;
            txtTongTien.Enabled = false;

            add = true;
        }

        private void dgv_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Enabled = false;
                txtTenNV.Enabled = false;
                txtTenKh.Enabled = false;
                dateHD.Enabled = false;
                txtTongTien.Enabled = false;
                int i;

                if (dgv_HD.Columns[e.ColumnIndex].Name == "chitiet")
                {
                    thongtinHD.ma = txtID.Text;
                    ViewTTHD hd = new ViewTTHD();
                    hd.Show();
                }

                i = dgv_HD.CurrentRow.Index;
                txtID.Text = dgv_HD.Rows[i].Cells[1].Value.ToString();
                txtTenNV.Text = dgv_HD.Rows[i].Cells[2].Value.ToString();
                txtTenKh.Text = dgv_HD.Rows[i].Cells[3].Value.ToString();
                dateHD.Text = dgv_HD.Rows[i].Cells[4].Value.ToString();
                txtTongTien.Text = dgv_HD.Rows[i].Cells[5].Value.ToString();

            }
            catch(Exception)
            {

            }
        }

        private void btn_Tim_HD_Click(object sender, EventArgs e)
        {
            HD_BanHang_Load(sender, e);
            if (txt_Tim_HD.Text.Trim() == "")
            {
                dgv_HD.DataSource = dt.hd();
            }
            dgv_HD.AutoGenerateColumns = false;
            dgv_HD.DataSource = dt.search_hdBan(txt_Tim_HD.Text);
        }

        //private void LoadData()
        //{
        //    try
        //    {
        //        dgv_HDBan.DataSource = HD_Ban.get_CTListHd();
        //    }
        //    catch(Exception)
        //    {

        //    }
        //}



    }
}
