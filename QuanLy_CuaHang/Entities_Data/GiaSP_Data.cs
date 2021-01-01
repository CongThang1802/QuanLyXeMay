using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public class GiaSP_Data
    {
        public static List<Get_GiaSPList_Result> Get_GiaSPList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Get_GiaSPList().ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Gia_SP Get_GiaSP(int ma_Gia)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Gia_SP.Where(p => p.ma_GiaSP == ma_Gia).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int Get_MaGiaSP()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.Gia_SP.Max(p => p.ma_GiaSP);
                }
            }
            catch (Exception)
            {
                return 10000;
            }
        }

        public static bool Add_GiaSP(Gia_SP gia_SP)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.Gia_SP.Add(gia_SP);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_GiaSP(int maGiaSP)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Gia_SP giaSP = entities.Gia_SP.Where(p => p.ma_GiaSP == maGiaSP).FirstOrDefault();
                    entities.Gia_SP.Remove(giaSP);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_GiaSP(Gia_SP gia_SP)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    Gia_SP giaSP = entities.Gia_SP.Where(p => p.ma_GiaSP == gia_SP.ma_GiaSP).FirstOrDefault();
                    giaSP.ngay_BDSP = gia_SP.ngay_BDSP;
                    giaSP.gia_SP1 = gia_SP.gia_SP1;
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
