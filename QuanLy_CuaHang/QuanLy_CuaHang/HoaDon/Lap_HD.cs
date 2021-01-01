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
    public partial class Lap_HD : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();

        public Lap_HD()
        {
            InitializeComponent();
        }
        public class thongtinHD
        {
            public static string ma;

        }
        int huhu = 0;

        private void Lap_HD_Load(object sender, EventArgs e)
        {
            huhu++;
            int i = 0;
            List<int> dem = new List<int>();
            foreach (var r in dt.HD_BanHangs)
            {
                dem.Add(r.ma_hd.GetHashCode());
                i++;
            }
            var a = dt.HD_BanHangs.FirstOrDefault();
            if (a == null)
            {
                lbMaHD.Text = "12001";
            }
            else
            {
                int max = dem[0];
                for (int j = 1; j < i; j++)
                {
                    if (max < dem[j])
                    {
                        max = dem[j];
                    }
                }
                if (max < 9)
                {
                    max = max + 1;
                    lbMaHD.Text = "" + max;
                }
                else if (max > 9)
                {
                    max = max + 1;
                    lbMaHD.Text = "" + max;
                }
            }
            cbbTenSP.DisplayMember = "ten_dm";
            cbbTenSP.ValueMember = "ma_dm";
            cbbTenSP.DataSource = dt.giasp().ToList();

            cbbMaKH.DisplayMember = "ten_hk";
            cbbMaKH.ValueMember = "ma_kh";
            cbbMaKH.DataSource = dt.KhachHangs.ToList();

            dgvHD.AutoGenerateColumns = false;

        }

        private void cbbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhachHang1 kh = dt.KhachHangs.Where(s => s.ma_KH == Convert.ToInt32(cbbMaKH.SelectedValue.ToString())).FirstOrDefault();
            lbMaKH.Text = kh.ma_KH.ToString();
            lbMail.Text = kh.mail_KH.ToString();
            lbSDT.Text = kh.sdt_KH.ToString();
        }

        private void cbbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            giaspResult gia = dt.giasp().Where(s => s.ma_DM == Convert.ToInt32(cbbTenSP.SelectedValue.ToString())).FirstOrDefault();
            lbDongia.Text = gia.gia_SP.ToString();
            txtMasp.Text = gia.ma_SP.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var HDX = dt.selectHoaDon(lbMaHD.Text).FirstOrDefault();
            if (txtSL.Text.Trim() == "" || txtSL.Text.Trim() == null)
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo");
            }
            else if (Convert.ToInt32(txtSL.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
            }
            else
            {
                if (HDX == null)
                {
                
                    dt.Insert_HoaDon(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbMaKH.SelectedValue), Form_LoginApp.TTNV.MaNV,
                        Convert.ToDateTime(DateTime.Now),  0);
                    dt.INSERT_CTHD(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(txtMasp.Text),Convert.ToInt32(lbDongia.Text) ,Convert.ToInt32(txtSL.Text),
                                        (Convert.ToInt32(txtSL.Text) * Convert.ToInt32(lbDongia.Text)));
                    double thanhtien = 0;
                    foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                    {
                        thanhtien = thanhtien + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);

                    }
                    dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(thanhtien));
                    MessageBox.Show("Thêm thành công", "Thêm");
                    var sp = dt.Procedure(Convert.ToInt32(cbbTenSP.SelectedValue.ToString())).FirstOrDefault();
                    label2.Text = sp.soluong_SP.ToString(); 
                }
                else if (HDX != null)
                {
                    var CTX = dt.selectAll_CTHD(Convert.ToInt32(lbMaHD.Text),Convert.ToInt32(txtMasp.Text)).FirstOrDefault();
                    if (CTX == null)
                    {
                        dt.INSERT_CTHD(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(txtMasp.Text), Convert.ToInt32(lbDongia.Text), Convert.ToInt32(txtSL.Text),
                                        (Convert.ToInt32(txtSL.Text) * Convert.ToInt32(lbDongia.Text)));
                        double thanhtien = 0;
                        foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                        {
                            thanhtien = thanhtien + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);
                        }
                        dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(thanhtien));
                        MessageBox.Show("Thêm thành công", "Thêm");
                        var sp = dt.Procedure(Convert.ToInt32(cbbTenSP.SelectedValue.ToString())).FirstOrDefault();
                        label2.Text = sp.soluong_SP.ToString();
                    }
                    else if (CTX != null)
                    {
                        dt.updateSL_CTHD(Convert.ToInt32(lbMaHD.Text),Convert.ToInt32(txtMasp.Text),Convert.ToInt32(lbDongia.Text) ,Convert.ToInt32(txtSL.Text) + CTX.soluong_SP,
                          Convert.ToInt32(CTX.tongtien_SP + (Convert.ToInt32(txtSL.Text) * Convert.ToInt32(lbDongia.Text))));
                        int thanhtien = 0;
                        foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                        {
                            thanhtien = thanhtien + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);
                        }
                        dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text),Convert.ToInt32(thanhtien));
                        MessageBox.Show("Thêm thành công", "Thêm");
                        var sp = dt.Procedure(Convert.ToInt32(cbbTenSP.SelectedValue.ToString())).FirstOrDefault();
                        label2.Text = sp.soluong_SP.ToString();
                    }
                }
            }
            dgvHD.DataSource = dt.selectCTHD(Convert.ToInt32(lbMaHD.Text));
            txtSL.ResetText();
            int TongTienHD = 0;
            //double TongTienDiscount = 0;
            foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
            {
                TongTienHD = TongTienHD + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);

            }
            dt.UPDATE_TONGTIEN(Convert.ToInt32(lbMaHD.Text), TongTienHD);
            lbTongTien.Text = TongTienHD.ToString("N0");

           

        }

        private void cbbTenSP_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (huhu == 1)
                {
                    cbbTenSP.DisplayMember = "Ten_dm";
                    cbbTenSP.ValueMember = "ma_dm";
                    cbbTenSP.DataSource = dt.giasp().ToList();
                }

                var sp = dt.Procedure(Convert.ToInt32(cbbTenSP.SelectedValue.ToString())).FirstOrDefault();
                label2.Text = sp.soluong_SP.ToString();
                huhu++;
            }
            catch (Exception)
            {
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Lỗi rồi", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            thongtinHD.ma = lbMaHD.Text;
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lbMaKH.Text = "";
            lbMail.Text = "";
            lbSDT.Text = "";
            txtSL.Text = "";
            txtMasp.Text = "";
            lbDongia.Text = "";
            Lap_HD_Load(sender, e);
            dgvHD.ClearSelection();
            dgvHD.DataSource = "";

        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHD.Columns[e.ColumnIndex].Name == "xoa")
            {
                DialogResult a = MessageBox.Show(" Ban co muon xoa khong?", "Xoa", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    //var HDX = dt.selectHoaDon(lbMaHD.Text).FirstOrDefault();
                    var sp = dt.selectSP11(Convert.ToInt32(txtMasp.Text)).FirstOrDefault();
                    var cthd = dt.CTHD_BanHangs.Where(s => s.ma_HD == Convert.ToInt32(lbMaHD.Text)).Where(s => s.ma_SP == Convert.ToInt32(txtMasp.Text)).FirstOrDefault();
                    dt.delete_cthd(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(txtMasp.Text));
                    //dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(THANHTIEN));
                    dt.updateSLT(Convert.ToInt32(txtMasp.Text), sp.soluong_SP + cthd.soluong_SP);
                    dgvHD.DataSource = dt.selectCTHD(Convert.ToInt32(lbMaHD.Text));
                    txtSL.ResetText();
                    label2.Text = sp.soluong_SP.ToString();
                    int TongTienHD = 0;
                    //double TongTienDiscount = 0;
                    foreach (var c in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                    {
                        TongTienHD = TongTienHD + Convert.ToInt32(c.gia_SP) * Convert.ToInt32(c.soluong_SP);

                    }
                    dt.UPDATE_TONGTIEN(Convert.ToInt32(lbMaHD.Text), TongTienHD);
                    lbTongTien.Text = TongTienHD.ToString("N0");
                    
                }
            }
        }
    }
}
