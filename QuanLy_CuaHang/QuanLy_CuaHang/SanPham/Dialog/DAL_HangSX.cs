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
    public partial class DAL_HangSX : Form
    {
        private int ma_HangSX;
        public DAL_HangSX(int hsx = -1)
        {
            InitializeComponent();
            this.ma_HangSX = hsx;
            Load_Data();
        }
        private void Load_Data()
        {
            txt_MaHangSX.ReadOnly = true;
            if (this.ma_HangSX == -1)
            {
                try
                {
                    txt_MaHangSX.Text = Entities_Data.HangSanXuat_Data.Get_MaHangSX() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    Entities_Data.Hang_SX hsx = Entities_Data.HangSanXuat_Data.Get_HangSX(this.ma_HangSX);
                    txt_MaHangSX.Text = hsx.ma_Hang.ToString();
                    txt_TenHangSX.Text = hsx.ten_Hang.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.ma_HangSX == -1)
            {
                Entities_Data.HangSanXuat_Data.Add_HangSX(new Entities_Data.Hang_SX()
                {
                    ma_Hang = int.Parse(txt_MaHangSX.Text.Trim()),
                    ten_Hang = txt_TenHangSX.Text
                });
            }
            else
            {
                Entities_Data.HangSanXuat_Data.Update_HangSX(new Entities_Data.Hang_SX()
                {
                    ma_Hang = int.Parse(txt_MaHangSX.Text.Trim()),
                    ten_Hang = txt_TenHangSX.Text
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
