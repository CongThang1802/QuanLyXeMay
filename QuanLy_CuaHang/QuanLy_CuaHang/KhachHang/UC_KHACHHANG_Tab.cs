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
    public partial class UC_KHACHHANG_Tab : UserControl
    {
        public UC_KHACHHANG_Tab()
        {
            InitializeComponent();
            Check_Tab();
        }

        private void Check_Tab()
        {
            switch (tab_QL_KhachHang.SelectedIndex)
            {
                case 0:
                    this.tab_TT_KhachHang.Controls.Clear();
                    this.tab_TT_KhachHang.Controls.Add(new UC_TT_KhachHang());
                    break;
                //case 1:
                //    this.tab_GiaSP.Controls.Clear();
                //    this.tab_GiaSP.Controls.Add(new UC_GiaSP_TT());
                //    break;
                //case 2:
                //    this.tab_HangSX_NCC.Controls.Clear();
                //    this.tab_HangSX_NCC.Controls.Add(new UC_NhaCC_HangSX());
                //    break;
                //case 3:
                //    this.tab_DanhM_LoaiSP.Controls.Clear();
                //    this.tab_DanhM_LoaiSP.Controls.Add(new UC_DanhM_LoaiSP());
                //    break;
            }
        }

        private void tab_QL_KhachHang_Click(object sender, EventArgs e)
        {
            Check_Tab();
        }
    }
}
