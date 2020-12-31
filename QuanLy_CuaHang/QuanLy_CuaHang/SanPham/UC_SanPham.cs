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
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
            Check_Tab();
        }

        private void tab_Control_Click(object sender, EventArgs e)
        {
            Check_Tab();
        }

        private void Check_Tab()
        {
            switch (tab_QL_SanPham.SelectedIndex)
            {
                case 0:
                    //this.tab_NhapSP.Controls.Add(uC_NhapSP);
                    break;
                case 1:
                    //views.UC_QuanLySanPham.UC_SanPham uC_SanPham = new UC_QuanLySanPham.UC_SanPham();
                    //this.tab_SanPham.Controls.Add(uC_SanPham);
                    break;
                case 2:
                    this.tab_HangSX_NCC.Controls.Clear();
                    this.tab_HangSX_NCC.Controls.Add(new UC_NhaCC_HangSX());
                    break;
                case 3:
                    this.tab_DanhM_LoaiSP.Controls.Clear();
                    this.tab_DanhM_LoaiSP.Controls.Add(new UC_DanhM_LoaiSP());
                    break;
            }
        }
    }
}
