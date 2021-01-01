using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.SanPham1.Dialog
{
    public partial class DAL_NhaCungCap : Form
    {
        public int ma_Ncc;
        public DAL_NhaCungCap(int ma_NCC = -1)
        {
            InitializeComponent();
            this.ma_Ncc = ma_NCC;
            Load_Data();
        }

        private void Load_Data()
        {
            txt_MaNCC.ReadOnly = true;
            if (this.ma_Ncc == -1)
            {
                try
                {
                    txt_MaNCC.Text = Entities_Data.NhaCungCap_Data.Get_MaNhaCungCap() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    Entities_Data.Nha_CungCap ncc = Entities_Data.NhaCungCap_Data.Get_NhaCungCap(this.ma_Ncc);
                    txt_MaNCC.Text = ncc.ma_NCC.ToString();
                    txt_TenNCC.Text = ncc.ten_NCC.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.ma_Ncc == -1)
            {
                Entities_Data.NhaCungCap_Data.Add_NhaCungCap(new Entities_Data.Nha_CungCap()
                {
                    ma_NCC = int.Parse(txt_MaNCC.Text.Trim()),
                    ten_NCC = txt_TenNCC.Text
                });
            }
            else
            {
                Entities_Data.NhaCungCap_Data.Update_NhaCungCap(new Entities_Data.Nha_CungCap()
                {
                    ma_NCC = int.Parse(txt_MaNCC.Text.Trim()),
                    ten_NCC = txt_TenNCC.Text
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
