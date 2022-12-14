using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ControleEstoque.Helpers
{
    public static class CriptoHelper
    {
        public static string HashMD5(string val)
        {
            var bytes = Encoding.ASCII.GetBytes(val);
            var md5 = MD5.Create(); // cria o hash
            var hash = md5.ComputeHash(bytes); // obtém criptografia a partir dos bytes

            var ret = string.Empty;
            for (int i = 0; i < hash.Length; i++)
            {
                ret += hash[i].ToString("x2");
            }

            return ret;
        }
    }
}