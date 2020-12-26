using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.QL_SaoLuu
{
    public partial class UC_QLSaoLuu : UserControl
    {
        public UC_QLSaoLuu()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string strPath = "";
            try
            {
                string strname = "TenCSDL(" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + ").bak";
                string strBackup = " BACKUP DATABASE [TenCSDL] TO DISK = N'" + strPath + strname + "'";
                strBackup += " WITH COPY_ONLY, NOFORMAT, NOINIT, NAME = N'TenCSDL-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                //KetNoi.ThucHienLenhKhongLayKetQua(strBackup);
            }
            catch { }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection sqlcon = new SqlConnection(strcon);
            //    sqlcon.Open();
            //    strPath = strPath.Substring(0, strPath.Length - 2);
            //    string stRestore = "ALTER DATABASE [TenCSDL] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
            //    stRestore += " RESTORE DATABASE [TenCSDL] FROM DISK = N'" + strPath + "'";
            //    stRestore += " WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
            //    stRestore += " ALTER DATABASE [TenCSDL] SET MULTI_USER ";
            //    SqlCommand cmd = new SqlCommand(stRestore, sqlcon);
            //    cmd.ExecuteNonQuery();
            //    sqlcon.Close();
            //}
            //catch { }

        }
    }
}
