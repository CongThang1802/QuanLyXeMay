using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public class SanPham_Data
    {
        public static List<Get_SanPhamList_Result> Get_SanPhamList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Get_SanPhamList().ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int Get_MaSanPham()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.SanPham.Max(p => p.ma_SP);
                }
            }
            catch (Exception)
            {
                return 14000;
            }
        }

        public static SanPham Get_SanPham(int maSP)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.SanPham.Where(p => p.ma_SP == maSP).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_SanPham(SanPham sanPham)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.SanPham.Add(sanPham);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_SanPham(SanPham sanPham)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    SanPham san_Pham = entities.SanPham.Where(p => p.ma_SP == sanPham.ma_SP).FirstOrDefault();
                    san_Pham.ten_SP = sanPham.ten_SP;
                    san_Pham.ma_Loai = sanPham.ma_Loai;
                    san_Pham.ma_Hang = sanPham.ma_Hang;
                    san_Pham.ma_DM = sanPham.ma_DM;
                    san_Pham.soluong_SP = sanPham.soluong_SP;
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_SanPham(int maSP)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    SanPham san_Pham = entities.SanPham.Where(p => p.ma_SP == maSP).FirstOrDefault();
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
