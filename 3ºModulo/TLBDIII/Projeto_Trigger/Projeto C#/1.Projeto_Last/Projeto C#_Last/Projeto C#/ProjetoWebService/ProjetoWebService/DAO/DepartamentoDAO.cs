using ProjetoWebService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoWebService.DAO
{
    public static class DepartamentoDAO
    {
        public static List<DepartamentoDTO> select()
        {
            String sql = "SELECT cd_dpto, nm_dpto, nm_localizacao FROM dpto";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<DepartamentoDTO> departamentoDTOs = new List<DepartamentoDTO>();
            while (dr.Read())
            {
                DepartamentoDTO departamento = new DepartamentoDTO();
                departamento.Id = dr.GetInt32(0);
                departamento.Nome = dr.GetString(1);
                departamento.Localizacao = dr.GetString(2);
                departamentoDTOs.Add(departamento);
            }
            conexao.Close();
            return departamentoDTOs;
        }
        public static bool insert(DepartamentoDTO departamento)
        {
            String sql = "INSERT INTO dpto (cd_dpto, nm_dpto, nm_localizacao) select coalesce(max(cd_dpto),0)+1, @nome" + ", @localizacao" + " from dpto";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = departamento.Nome;
            comando.Parameters.Add(new MySqlParameter("@localizacao", MySqlDbType.VarChar)).Value = departamento.Localizacao;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool update(DepartamentoDTO departamento)
        {
            String sql = "UPDATE dpto SET nm_dpto = @nome"+", nm_localizacao = @localizacao" + " WHERE cd_dpto = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = departamento.Nome;
            comando.Parameters.Add(new MySqlParameter("@localizacao", MySqlDbType.VarChar)).Value = departamento.Localizacao;
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = departamento.Id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool delete(int id)
        {
            String sql = "DELETE FROM dpto WHERE cd_dpto = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static DepartamentoDTO search(int id)
        {
            String sql = "SELECT cd_dpto, nm_dpto, nm_localizacao FROM dpto WHERE cd_dpto = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            DepartamentoDTO departamento = new DepartamentoDTO();
            if (dr.Read())
            {
                departamento.Id = dr.GetInt32(0);
                departamento.Nome = dr.GetString(1);
                departamento.Localizacao = dr.GetString(2);
            }
            conexao.Close();
            return departamento;
        }

        public static List<DepartamentoDTO> func_depart()
        {
            String sql = "call func_depart();";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<DepartamentoDTO> departamentos = new List<DepartamentoDTO>();
            while (dr.Read()) {
                DepartamentoDTO departamento = new DepartamentoDTO();
                departamento.Nome = dr.GetString(1);
                departamento.Localizacao = dr.GetString(2);
                departamentos.Add(departamento);
            }
            conexao.Close();
            return departamentos;
        }

        public static List<DepartamentoDTO> func_depart_cod(int codigo) {
            String sql = "call func_depart_cod();";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@codigo", MySqlDbType.Int64)).Value = codigo;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<DepartamentoDTO> departamentos = new List<DepartamentoDTO>();
            while (dr.Read())
            {
                DepartamentoDTO departamento = new DepartamentoDTO();
                departamento.Nome = dr.GetString(0);
                departamentos.Add(departamento);
            }
            conexao.Close();
            return departamentos;
        }
    }
}