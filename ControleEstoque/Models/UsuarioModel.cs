using ControleEstoque.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ControleEstoque.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = false;
            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ControleEstoque;User Id=sa; Password=123456";
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format( 
                        "select count(*) from usuario where login='{0}' and senha='{1}'",
                        login, CriptoHelper.HashMD5(senha));
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }

            return ret;
        }
    }
}