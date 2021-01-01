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
                    Lap_HD objForm = new Lap_HD();
                    objForm.TopLevel = false;
                    tabPage4.Controls.Add(objForm);
                    objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    objForm.Dock = DockStyle.Fill;
                    objForm.Show();
                    break;
                case 2:
                    
                    this.tabPage2.Controls.Clear();
                    this.tabPage2.Controls.Add(new HD_DV());
                    break;
                case 3:
                    
                    break;
            }
        }
    }
}
