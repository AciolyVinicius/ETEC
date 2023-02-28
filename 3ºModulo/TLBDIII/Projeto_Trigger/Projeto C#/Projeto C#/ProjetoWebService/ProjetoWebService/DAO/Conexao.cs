using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoWebService.DAO
{
    public static class Conexao
    {
        public static MySqlConnection getConexao()
        {
            MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306; username = root; password = usbw; database = dpto_projeto");
            return conexao;
        }
    }
}