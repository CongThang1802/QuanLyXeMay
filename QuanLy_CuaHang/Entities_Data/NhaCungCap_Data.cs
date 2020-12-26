using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class NhaCungCap_Data
    {
        public static List<Nha_CungCap> Get_NhaCungCapList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Nha_CungCap.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int Get_MaNhaCungCap()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Nha_CungCap.Max(p => p.ma_NCC);
                }
            }
            catch (Exception)
            {
                return 1000;
            }
        }

        public static Nha_CungCap Get_NhaCungCap(int ma_NCC)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Nha_CungCap.Where(p => p.ma_NCC == ma_NCC).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_NhaCungCap(Nha_CungCap ncc)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.Nha_CungCap.Add(ncc);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_NhaCungCap(Nha_CungCap ncc)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Nha_CungCap nha_CungCap = entities.Nha_CungCap.Where(p => p.ma_NCC == ncc.ma_NCC).FirstOrDefault();
                    nha_CungCap.ten_NCC = ncc.ten_NCC;
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_NhaCungCap(int ma_NCC)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Nha_CungCap nha_CungCap = entities.Nha_CungCap.Where(p => p.ma_NCC == ma_NCC).FirstOrDefault();
                    entities.Nha_CungCap.Remove(nha_CungCap);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<Nha_CungCap> Search_NhaCC(string key)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Nha_CungCap.Where(p => p.ten_NCC.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
