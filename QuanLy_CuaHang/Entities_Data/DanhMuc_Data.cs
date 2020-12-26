using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class DanhMuc_Data
    {
        public static List<DanhMuc> Get_DanhMucList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.DanhMuc.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int Get_MaDanhMuc()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.DanhMuc.Max(p => p.ma_DM);
                }
            }
            catch (Exception)
            {
                return 4000;
            }
        }

        public static DanhMuc Get_DanhMuc(int maDM)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.DanhMuc.Where(p => p.ma_DM == maDM).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_DanhMuc(DanhMuc danhMuc)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.DanhMuc.Add(danhMuc);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_DanhMuc(DanhMuc danh_Muc)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    DanhMuc danhMuc = entities.DanhMuc.Where(p => p.ma_DM == danh_Muc.ma_DM).FirstOrDefault();
                    danhMuc.ten_DM = danh_Muc.ten_DM;
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete_HangSX(int ma_DanhMuc)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    DanhMuc danhMuc = entities.DanhMuc.Where(p => p.ma_DM == ma_DanhMuc).FirstOrDefault();
                    entities.DanhMuc.Remove(danhMuc);
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
