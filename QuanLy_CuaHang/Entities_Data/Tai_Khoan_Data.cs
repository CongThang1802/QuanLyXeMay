using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class Tai_Khoan_Data
    {
        public static List<NhanVien> getNhanvien_List()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.NhanVien.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<NhanVien> Search_TTNhanVien(string value)
        {
            try {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.NhanVien.Where(p => p.ten_NV.Contains(value)).ToList();
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public static bool ChangePass(NhanVien nhanVien)
        {
            try
            {
                using(CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    NhanVien nhanVien1 = entities.NhanVien.Where(p => p.ma_NV == nhanVien.ma_NV).FirstOrDefault();
                    nhanVien.mk_DangNhap = nhanVien.mk_DangNhap;
                    entities.SaveChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

        public static Get_TKNhanVien_Result GetNhanVien(int value)
        {
            using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Get_TKNhanVien(value).FirstOrDefault();
                }
            
        }

        public static bool Add_NhanVien ( NhanVien nhanVien)
        {
            try
            {
                using(CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.NhanVien.Add(nhanVien);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool Edit_NhanVien( NhanVien nhanVien)
        {
            try
            {
                using(CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    NhanVien nhanVien1 = entities.NhanVien.Where(p => p.ma_NV == nhanVien.ma_NV).FirstOrDefault();
                    nhanVien1.ten_NV = nhanVien.ten_NV;
                    nhanVien1.mail_NV = nhanVien.mail_NV;
                    nhanVien1.sdt_NV = nhanVien.sdt_NV;

                    entities.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool Delete_NhanVien(int value)
        {
            try
            {
                using(CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.NhanVien.Remove(entities.NhanVien.Where(p => p.ma_NV == value).FirstOrDefault());
                    entities.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool Update_NhanVien(int manv,string gmail,string sdt, string pass)
        {
            try
            {
                using(CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    NhanVien nhanVien = entities.NhanVien.Where(p => p.ma_NV == manv).FirstOrDefault();
                    nhanVien.mail_NV = gmail;
                    nhanVien.sdt_NV = sdt;
                    nhanVien.mk_DangNhap = pass;
                    entities.SaveChanges();
                    return true;

                }

            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
