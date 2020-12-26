using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class HangSanXuat_Data
    {
        public static List<Hang_SX> Get_HangSanXuatList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Hang_SX.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int Get_MaHangSX()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Hang_SX.Max(p => p.ma_Hang);
                }
            }
            catch (Exception)
            {
                return 3000;
            }
        }

        public static Hang_SX Get_HangSX(int ma_Hang)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Hang_SX.Where(p => p.ma_Hang == ma_Hang).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_HangSX(Hang_SX hangSX)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.Hang_SX.Add(hangSX);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_HangSX(Hang_SX hangSX)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Hang_SX hangSx = entities.Hang_SX.Where(p => p.ma_Hang == hangSX.ma_Hang).FirstOrDefault();
                    hangSx.ten_Hang = hangSX.ten_Hang;
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete_HangSX(int ma_Hang)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Hang_SX hang_SX = entities.Hang_SX.Where(p => p.ma_Hang == ma_Hang).FirstOrDefault();
                    entities.Hang_SX.Remove(hang_SX);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Hang_SX> Search_HangSX(string key)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Hang_SX.Where(p => p.ten_Hang.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
