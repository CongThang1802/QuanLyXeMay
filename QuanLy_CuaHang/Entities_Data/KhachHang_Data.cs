using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class KhachHang_Data
    {
        public static List<KhachHang> Get_KhachHangList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.KhachHang.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_KhachHang(KhachHang khachHang)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.KhachHang.Add(khachHang);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_KhachHang(KhachHang khachHang)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    KhachHang khach_Hang = entities.KhachHang.Where(p => p.ma_KH == khachHang.ma_KH).FirstOrDefault();
                    khach_Hang.ten_HK = khachHang.ten_HK;
                    khach_Hang.mail_KH = khachHang.mail_KH;
                    khach_Hang.sdt_KH = khachHang.sdt_KH;
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_KhachHang(int maKH)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    KhachHang khach_Hang = entities.KhachHang.Where(p => p.ma_KH == maKH).FirstOrDefault();
                    entities.KhachHang.Remove(khach_Hang);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int Get_MaKhachHang()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.KhachHang.Max(p => p.ma_KH);
                }
            }
            catch (Exception)
            {
                return 7000;
            }
        }

        public static KhachHang Get_KhachHang(int maKH)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.KhachHang.Where(p => p.ma_KH == maKH).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
