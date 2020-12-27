using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_CuaHang.models
{
    public static class MD5_Hash
    {
        public static string MD5Hash(string input)
        {
            StringBuilder builder = new StringBuilder();
            MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider();
            byte[] bytes = mD5.ComputeHash(new UTF8Encoding().GetBytes(input));

            for(int i = 0; i<bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));

            }
            return builder.ToString();
        }
    }
}
