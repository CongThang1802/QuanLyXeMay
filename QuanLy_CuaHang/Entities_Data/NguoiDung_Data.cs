using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class NguoiDung_Data
    {
        public static List<NhanVien> Get_NhanVienList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.NhanVien.ToList();
                }
            }
            catch(Exception)
            {
                return null;
            }            
        }

        public static List<ChucNang> Get_ChucNangList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.ChucNang.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<CT_Quyen> Get_CTQuyenList(int ma_NV)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.CT_Quyen.Where(p => p.ma_NV == ma_NV).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
