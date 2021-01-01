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
    public partial class DAL_GiaSP : Form
    {
        private int ma_GiaSP;
        public DAL_GiaSP(int ma_Gia = -1)
        {
            InitializeComponent();
            this.ma_GiaSP = ma_Gia;
            Load_Combobox();
            Load_Data();
        }

        private void Load_Combobox()
        {
            cbb_TenSP.DataSource = Entities_Data.SanPham_Data.Get_SanPhamList();
            cbb_TenSP.DisplayMember = "ten_SP";
            cbb_TenSP.ValueMember = "ma_SP";
        }

        private void Load_Data()
        {
            if(this.ma_GiaSP != -1)
            {
                Entities_Data.Gia_SP gia_SP = Entities_Data.GiaSP_Data.Get_GiaSP(this.ma_GiaSP);
                
                cbb_TenSP.SelectedValue = gia_SP.ma_SP;
                txt_MaGiaSP.Text = gia_SP.ma_GiaSP.ToString();
                dtp_NgayApDung.Value = (DateTime)gia_SP.ngay_BDSP;
                txt_Gia.Text = gia_SP.gia_SP1.ToString();
            }
            else
            {
                txt_MaGiaSP.Text = Entities_Data.GiaSP_Data.Get_MaGiaSP()+1+"";
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txt_Gia.Text.Trim() != "")
            {
                if (this.ma_GiaSP != -1)
                {
                    Entities_Data.GiaSP_Data.Update_GiaSP(new Entities_Data.Gia_SP()
                    {
                        ma_GiaSP = int.Parse(txt_MaGiaSP.Text.Trim()),
                        ma_SP = int.Parse(cbb_TenSP.SelectedValue.ToString()),
                        gia_SP1 = int.Parse(txt_Gia.Text.Trim()),
                        ngay_BDSP = dtp_NgayApDung.Value
                    });
                }
                else
                {
                    Entities_Data.GiaSP_Data.Add_GiaSP(new Entities_Data.Gia_SP()
                    {
                        ma_GiaSP = int.Parse(txt_MaGiaSP.Text.Trim()),
                        ma_SP = int.Parse(cbb_TenSP.SelectedValue.ToString()),
                        gia_SP1 = int.Parse(txt_Gia.Text.Trim()),
                        ngay_BDSP = dtp_NgayApDung.Value
                    });
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập giá!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
