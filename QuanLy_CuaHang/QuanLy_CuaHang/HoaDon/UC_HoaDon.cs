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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
            checkTab();
        }

        private void tab_Ctr_HDBan_Click(object sender, EventArgs e)
        {
            checkTab();
        }

        private void checkTab()
        {
            switch(tab_Ctr_HDBan.SelectedIndex)
            {
                case 0:
                    this.tabPage1.Controls.Clear();
                    this.tabPage1.Controls.Add(new HD_BanHang());
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
