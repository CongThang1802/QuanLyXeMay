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
    public partial class HD_BanHang : UserControl
    {
        public HD_BanHang()
        {
            InitializeComponent();
            LoadData();
            dgv_HDBan.ColumnHeadersHeight = 24;
            
            dgv_HDBan.Columns[0].HeaderText = "Mã HD";
            dgv_HDBan.Columns[1].HeaderText = "Tên Nv";
            dgv_HDBan.Columns[2].HeaderText = "Tên KH";
            dgv_HDBan.Columns[3].HeaderText = "Tên SP";
            dgv_HDBan.Columns[4].HeaderText = "Màu Sắc";
            dgv_HDBan.Columns[5].HeaderText = "Gía bán";
            dgv_HDBan.Columns[6].HeaderText = "Số lượng";
            dgv_HDBan.Columns[7].HeaderText = "Thành Tiền";
            dgv_HDBan.Columns[0].Width = 50;

        }

        private void LoadData()
        {
            try
            {
                dgv_HDBan.DataSource = Entities_Data.HD_Ban.get_CTListHd();
            }
            catch (Exception)
            {
                
            }

        }
        
    }
}
