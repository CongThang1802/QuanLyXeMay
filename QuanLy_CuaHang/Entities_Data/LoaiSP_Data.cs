using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class LoaiSP_Data
    {
        public static List<Loai_SP> Get_LoaiSPList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Loai_SP.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int Get_MaLoaiSP()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Loai_SP.Max(p => p.ma_Loai);
                }
            }
            catch (Exception)
            {
                return 2000;
            }
        }

        public static Loai_SP Get_LoaiSP(int maLoai)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Loai_SP.Where(p => p.ma_Loai == maLoai).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_HangSX(Loai_SP loaiSP)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.Loai_SP.Add(loaiSP);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_LoaiSP(Loai_SP loaiSP)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Loai_SP loai_SP = entities.Loai_SP.Where(p => p.ma_Loai == loaiSP.ma_Loai).FirstOrDefault();
                    loai_SP.ten_Loai = loaiSP.ten_Loai;
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete_LoaiSP(int maLoai)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Loai_SP loai_SP = entities.Loai_SP.Where(p => p.ma_Loai == maLoai).FirstOrDefault();
                    entities.Loai_SP.Remove(loai_SP);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Loai_SP> Search_LoaiSP(string key)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Loai_SP.Where(p => p.ten_Loai.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
