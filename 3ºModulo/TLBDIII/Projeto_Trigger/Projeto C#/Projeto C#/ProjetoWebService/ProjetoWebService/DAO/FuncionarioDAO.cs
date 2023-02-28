using ProjetoWebService.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetoWebService.DAO
{
    public class FuncionarioDAO
    {
        public static List<FuncionarioDTO> select()
        {
            String sql = "SELECT cd_func, nm_func, nm_endereco, cd_telefone, vl_salario, cd_dpto, cd_dpto_gerenciar FROM func";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarioDTOs = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Id = dr.GetInt32(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Endereco = dr.GetString(2);
                funcionario.Telefone = dr.GetString(3);
                funcionario.Salario = dr.GetDouble(4);

                funcionario.Departamento = DepartamentoDAO.search(dr.GetInt32(5));
                if (dr.GetInt32(6) > 0)
                {
                    funcionario.DepartamentoGerenciar = DepartamentoDAO.search(dr.GetInt32(6));
                }
                funcionarioDTOs.Add(funcionario);
            }
            conexao.Close();
            return funcionarioDTOs;
        }

      public static bool insert(FuncionarioDTO funcionario)
        {
            String sql = "INSERT INTO func (cd_func, nm_func, nm_endereco, cd_telefone, vl_salario, cd_dpto, cd_dpto_gerenciar) select coalesce(max(cd_func),0)+1, @nome" + ", @endereco" + ", @telefone" + ", @salario" + ", @departamento" + ", @departamentoGerenciar" + " from func";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = funcionario.Nome;
            comando.Parameters.Add(new MySqlParameter("@endereco", MySqlDbType.VarChar)).Value = funcionario.Endereco;
            comando.Parameters.Add(new MySqlParameter("@telefone", MySqlDbType.VarChar)).Value = funcionario.Telefone;
            comando.Parameters.Add(new MySqlParameter("@salario", MySqlDbType.Decimal)).Value = funcionario.Salario;
            comando.Parameters.Add(new MySqlParameter("@departamento", MySqlDbType.Int64)).Value = funcionario.Departamento.Id;
            comando.Parameters.Add(new MySqlParameter("@departamentoGerenciar", MySqlDbType.Int64)).Value = funcionario.DepartamentoGerenciar.Id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool update(FuncionarioDTO funcionario)
        {
            String sql = "UPDATE func SET nm_func = @nome" + ", nm_endereco = @endereco" + ", cd_telefone = @telefone" + ", vl_salario = @salario" + ", cd_dpto = @departamento" + ", cd_dpto_gerenciar = @departamentoGerenciar" + " WHERE cd_func = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = funcionario.Nome;
            comando.Parameters.Add(new MySqlParameter("@endereco", MySqlDbType.VarChar)).Value = funcionario.Endereco;
            comando.Parameters.Add(new MySqlParameter("@telefone", MySqlDbType.VarChar)).Value = funcionario.Telefone;
            comando.Parameters.Add(new MySqlParameter("@salario", MySqlDbType.Decimal)).Value = funcionario.Salario;
            comando.Parameters.Add(new MySqlParameter("@departamento", MySqlDbType.Int64)).Value = funcionario.Departamento.Id;
            comando.Parameters.Add(new MySqlParameter("@departamentoGerenciar", MySqlDbType.Int64)).Value = funcionario.DepartamentoGerenciar.Id;
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = funcionario.Id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static bool delete(int id)
        {
            String sql = "DELETE FROM func WHERE cd_func = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            int linhasAfetadas = 0;
            conexao.Open();
            linhasAfetadas = comando.ExecuteNonQuery();
            conexao.Close();
            return linhasAfetadas != 0 ? true : false;
        }
        public static FuncionarioDTO search(int id)
        {
            String sql = "SELECT cd_func, nm_func, nm_endereco, cd_telefone, vl_salario, cd_dpto, cd_dpto_gerenciar FROM func WHERE cd_func = @id";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int64)).Value = id;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            FuncionarioDTO funcionario = new FuncionarioDTO();
            if (dr.Read())
            {
                funcionario.Id = dr.GetInt32(0);
                funcionario.Nome = dr.GetString(1);
                funcionario.Endereco = dr.GetString(2);
                funcionario.Telefone = dr.GetString(3);
                funcionario.Salario = dr.GetDouble(4);

                funcionario.Departamento = DepartamentoDAO.search(dr.GetInt32(5));
                if (dr.GetInt32(6) > 0)
                {
                    funcionario.DepartamentoGerenciar = DepartamentoDAO.search(dr.GetInt32(6));
                }
            }
            conexao.Close();
            return funcionario;
        }
        
        public static List<FuncionarioDTO> func3(int id, int id2, int id3) {
            String sql = "call 3func(@id1" + ", @id2" + ", @id3" + ");";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@id1", MySqlDbType.Int64)).Value = id;
            comandoSelect.Parameters.Add(new MySqlParameter("@id2", MySqlDbType.Int64)).Value = id2;
            comandoSelect.Parameters.Add(new MySqlParameter("@id3", MySqlDbType.Int64)).Value = id3;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Nome = dr.GetString(0);
                funcionario.Endereco = dr.GetString(1);
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            return funcionarios;
        }

      public static List<FuncionarioDTO> func_depart_maiorque(int valor)
        {
            String sql = "call func_depart_maiorque(@valor);";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@valor", MySqlDbType.Int64)).Value = valor;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read()) {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Nome = dr.GetString(0);
                funcionario.Departamento = DepartamentoDAO.search(dr.GetInt32(1));
                if (dr.GetInt32(2) > 0) {
                    funcionario.DepartamentoGerenciar = DepartamentoDAO.search(dr.GetInt32(2));
                }
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            return funcionarios;
        }
        
        public static List<FuncionarioDTO> func_funcionarios_projeto() {
            String sql = "call projetos_funcionarios();";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Nome = dr.GetString(0);
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            conexao.Close();
            return funcionarios;
        }

        public static List<FuncionarioDTO> func_dependente_filhoa() {
            String sql = "call func_dependente_filhoa();";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Nome = dr.GetString(0);
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            conexao.Close();
            return funcionarios;
        }

        public static List<FuncionarioDTO> func_salario_maior_menor(float maior, float menor) {
            String sql = "call func_salario_maior_menor(@maior, @menor);";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@maior", MySqlDbType.Int64)).Value = maior;
            comandoSelect.Parameters.Add(new MySqlParameter("@menor", MySqlDbType.Int64)).Value = menor;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Nome = dr.GetString(0);
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            conexao.Close();
            return funcionarios;
        }

        public static List<FuncionarioDTO> func_cidade_inicial(char inicial)
        {
            String sql = "call func_salario_maior_menor(@inicial);";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@inicial", MySqlDbType.VarChar)).Value = inicial;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Endereco = dr.GetString(0);
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            return funcionarios;
        }

        public static List<FuncionarioDTO> func_dependente_nao_filhoa()
        {
            String sql = "call func_dependente_nao_filhoa();";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Nome = dr.GetString(0);
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            conexao.Close();
            return funcionarios;
        }

        public static List<FuncionarioDTO> func_depart_gerenciam_em_projeto()
        {
            String sql = "call func_depart_gerenciam_em_projeto();";
            MySqlConnection conexao = Conexao.getConexao();
            MySqlCommand comandoSelect = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            List<FuncionarioDTO> funcionarios = new List<FuncionarioDTO>();
            while (dr.Read())
            {
                FuncionarioDTO funcionario = new FuncionarioDTO();
                funcionario.Nome = dr.GetString(0);
                funcionario.Departamento = DepartamentoDAO.search(dr.GetInt32(1));
                if (dr.GetInt32(2) > 0)
                {
                    funcionario.DepartamentoGerenciar = DepartamentoDAO.search(dr.GetInt32(2));
                }
                funcionarios.Add(funcionario);
            }
            conexao.Close();
            conexao.Close();
            return funcionarios;
        }
    }
}