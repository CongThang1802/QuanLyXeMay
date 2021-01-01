using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class HD_Ban
    {
        public static List<HD_BanHang> Get_ListHD()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.HD_BanHang.ToList();
                }
            }catch(Exception)
            {
                return null;
            }
        }
        public static List<ChiTiet_HD_Result> get_CTListHd()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    List<ChiTiet_HD_Result> lst = entities.ChiTiet_HD().ToList();
                    return lst;
                }

            }catch(Exception)
            {
                return null;
            }
        }

        public static List<hd_Result> Search_HoaDonList(string value)
        {
            using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
            {
                return entities.hd().Where(p=> p.ten_HK.Contains(value)).ToList();
            }
        }

    }
}
