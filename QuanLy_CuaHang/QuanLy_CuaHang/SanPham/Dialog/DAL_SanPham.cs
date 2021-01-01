using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.SanPham.Dialog
{
    public partial class DAL_SanPham : Form
    {
        private int ma_SP;
        public DAL_SanPham(int maSP = -1)
        {
            InitializeComponent();
            
            this.ma_SP = maSP;
            Load_Data();
        }

        private void Load_Data()
        {
            cbb_DanhMuc.DataSource = Entities_Data.DanhMuc_Data.Get_DanhMucList();
            cbb_DanhMuc.DisplayMember = "ten_DM";
            cbb_DanhMuc.ValueMember = "ma_DM";

            cbb_Hang.DataSource = Entities_Data.HangSanXuat_Data.Get_HangSanXuatList();
            cbb_Hang.DisplayMember = "ten_Hang";
            cbb_Hang.ValueMember = "ma_Hang";

            cbb_Loai.DataSource = Entities_Data.LoaiSP_Data.Get_LoaiSPList();
            cbb_Loai.DisplayMember = "ten_Loai";
            cbb_Loai.ValueMember = "ma_Loai";

            if (this.ma_SP == -1)
            {
                txt_Ma_SP.Text = Entities_Data.SanPham_Data.Get_MaSanPham() + 1 + "";
            }
            else
            {
                Entities_Data.SanPham sanPham = Entities_Data.SanPham_Data.Get_SanPham(this.ma_SP);
                txt_Ma_SP.Text = sanPham.ma_SP.ToString();
                txt_Ten_SP.Text = sanPham.ten_SP.ToString();
                cbb_DanhMuc.SelectedValue = sanPham.ma_DM;
                cbb_Hang.SelectedValue = sanPham.ma_Hang;
                cbb_Loai.SelectedValue = sanPham.ma_Loai;
                nbr_Soluong.Value = int.Parse(sanPham.soluong_SP.ToString());
            }
            
        }

        private void btn_Them_DM_Click(object sender, EventArgs e)
        {
            Dialog.DAL_DanhMuc dAL_SanPham = new Dialog.DAL_DanhMuc();
            dAL_SanPham.ShowDialog();
        }

        private void btn_Them_Loai_Click(object sender, EventArgs e)
        {
            Dialog.DAL_LoaiSP dAL_SanPham = new Dialog.DAL_LoaiSP();
            dAL_SanPham.ShowDialog();
        }

        private void btn_Them_Hang_Click(object sender, EventArgs e)
        {
            Dialog.DAL_HangSX dAL_SanPham = new Dialog.DAL_HangSX();
            dAL_SanPham.ShowDialog();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(this.ma_SP == -1)
            {
                Entities_Data.SanPham_Data.Add_SanPham(new Entities_Data.SanPham()
                {
                    ma_SP = int.Parse(txt_Ma_SP.Text.Trim()),
                    ten_SP = txt_Ten_SP.Text.ToString(),
                    ma_DM = int.Parse(cbb_DanhMuc.SelectedValue.ToString()),
                    ma_Hang = int.Parse(cbb_Hang.SelectedValue.ToString()),
                    ma_Loai = int.Parse(cbb_Loai.SelectedValue.ToString()),
                    soluong_SP = 0
                });
            }
            else
            {
                Entities_Data.SanPham_Data.Update_SanPham(new Entities_Data.SanPham()
                {
                    ma_SP = int.Parse(txt_Ma_SP.Text.Trim()),
                    ten_SP = txt_Ten_SP.Text.ToString(),
                    ma_DM = int.Parse(cbb_DanhMuc.SelectedValue.ToString()),
                    ma_Hang = int.Parse(cbb_Hang.SelectedValue.ToString()),
                    ma_Loai = int.Parse(cbb_Loai.SelectedValue.ToString()),
                    soluong_SP = int.Parse(nbr_Soluong.Value.ToString())
                });
            }
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
