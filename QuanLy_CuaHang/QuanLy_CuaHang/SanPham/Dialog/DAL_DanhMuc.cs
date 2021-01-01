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
    public partial class DAL_DanhMuc : Form
    {
        private int ma_DM;
        public DAL_DanhMuc(int maDM = -1)
        {
            InitializeComponent();
            this.ma_DM = maDM;
            Load_Data();
        }
        private void Load_Data()
        {
            txt_MaDM.ReadOnly = true;
            if (this.ma_DM == -1)
            {
                try
                {
                    txt_MaDM.Text = Entities_Data.DanhMuc_Data.Get_MaDanhMuc() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    Entities_Data.DanhMuc hsx = Entities_Data.DanhMuc_Data.Get_DanhMuc(this.ma_DM);
                    txt_MaDM.Text = hsx.ma_DM.ToString();
                    txt_TenDM.Text = hsx.ten_DM.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.ma_DM == -1)
            {
                Entities_Data.DanhMuc_Data.Add_DanhMuc(new Entities_Data.DanhMuc()
                {
                    ma_DM = int.Parse(txt_MaDM.Text.Trim()),
                    ten_DM = txt_TenDM.Text
                });
            }
            else
            {
                Entities_Data.DanhMuc_Data.Update_DanhMuc(new Entities_Data.DanhMuc()
                {
                    ma_DM = int.Parse(txt_MaDM.Text.Trim()),
                    ten_DM = txt_TenDM.Text
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
