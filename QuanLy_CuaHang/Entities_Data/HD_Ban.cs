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
            }catch(Exception ex)
            {
                return null;
            }
        }
        public static List<CThd_Result> get_CTListHd()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.CThd().ToList();
                }

            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
