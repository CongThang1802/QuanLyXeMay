using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace QuanLy_CuaHang
{
    public partial class Form_MainApp : Form
    {
        public Form_MainApp()
        {
            InitializeComponent();
            //this.btn_HOADON.Visible = false;
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ChucNang_Click(object sender, EventArgs e)
        {
            GunaButton button = sender as GunaButton;
            pnl_Select.Visible = true;
            pnl_NoiDung.Controls.Clear();
            switch (button.Name)
            {
                case "btn_HOADON":
                    pnl_NoiDung.Controls.Add(new HoaDon.UC_HoaDon());
                    pnl_Select.Location = new Point(0, btn_HOADON.Location.Y+183);
                    break;
                case "btn_THONGKE":
                    //pnl_NoiDung.Controls.Add(new QL_NguoiDung.UC_QLNguoiDung());
                    pnl_Select.Location = new Point(0, btn_THONGKE.Location.Y+183);
                    break;
                case "btn_SANPHAM":
                    pnl_NoiDung.Controls.Add(new SanPham.UC_SanPham());
                    pnl_Select.Location = new Point(0, btn_SANPHAM.Location.Y+183);
                    break;
                case "btn_KHACHHANG":
                    pnl_NoiDung.Controls.Add(new KhachHang.UC_KHACHHANG());
                    pnl_Select.Location = new Point(0, btn_KHACHHANG.Location.Y+183);
                    break;
                case "btn_NGUOIDUNG":                    
                    pnl_NoiDung.Controls.Add(new QL_NguoiDung.UC_QLNguoiDung());
                    pnl_Select.Location = new Point(0, btn_NGUOIDUNG.Location.Y+183);
                    break;
                case "btn_DATA":
                    pnl_NoiDung.Controls.Add(new QL_SaoLuu.UC_QLSaoLuu());
                    pnl_Select.Location = new Point(0, btn_DATA.Location.Y+183);
                    break;
            }
        }
    }
}
