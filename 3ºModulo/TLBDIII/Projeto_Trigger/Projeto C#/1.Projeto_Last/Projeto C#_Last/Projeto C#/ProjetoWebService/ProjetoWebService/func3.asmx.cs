using MySql.Data.MySqlClient;
using ProjetoWebService.DAO;
using ProjetoWebService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProjetoWebService
{
    /// <summary>
    /// Summary description for func3
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class func3 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<String> func(int id1, int id2, int id3)
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func3(id1, id2, id3);
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Nome);
                retorno.Add(func.Endereco);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_funcionarios_projeto()
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func_funcionarios_projeto();
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Nome);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_funcionarios_filhoa()
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func_dependente_filhoa();
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Nome);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> departamentos()
        {
            List<DepartamentoDTO> departamentos = DepartamentoDAO.func_depart();
            List<String> retorno = new List<String>();
            foreach (DepartamentoDTO depart in departamentos)
            {
                retorno.Add(depart.Nome);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_salario_maior_menor(float maior, float menor)
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func_salario_maior_menor(maior, menor);
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Id.ToString());
                retorno.Add(func.Nome);
                retorno.Add(func.Endereco);
                retorno.Add(func.Telefone);
                retorno.Add(func.Salario.ToString());
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_dependente()
        {
            List<DependenteDTO> dependente = DependenteDAO.func_dependente();
            List<String> retorno = new List<String>();
            foreach (DependenteDTO dep in dependente)
            {
                retorno.Add(dep.Nome);
                retorno.Add(dep.Parentesco);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_cidade_inicial(string inicial)
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func_cidade_inicial(inicial);
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Endereco);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_proj_verb_indefinida_xbolsas(int bolsas)
        {
            List<ProjetoDTO> projetos = ProjetoDAO.func_proj_verb_indefinida_xbolsas(bolsas);
            List<String> retorno = new List<String>();
            foreach (ProjetoDTO proj in projetos)
            {
                retorno.Add(proj.Verba);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_proj_verb_indefinida_xtipo(string tipo)
        {
            List<ProjetoDTO> projetos = ProjetoDAO.func_proj_verb_indefinida_xtipo(tipo);
            List<String> retorno = new List<String>();
            foreach (ProjetoDTO proj in projetos)
            {
                retorno.Add(proj.Tipo);
                retorno.Add(proj.Verba);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> func_dependente_nao_filhoa()
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func_dependente_nao_filhoa();
            List<DependenteDTO> dependentes = DependenteDAO.func_dependente();
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios) {
                retorno.Add(func.Nome);
                foreach (DependenteDTO dep in dependentes) {
                    retorno.Add(dep.Parentesco);
                    retorno.Add(dep.Nome);
                }
            }
            
            return retorno;
        }

        [WebMethod]
        public List<String> func_depart_gerenciam_em_projeto()
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func_depart_gerenciam_em_projeto();
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Nome);
                retorno.Add(func.Departamento.ToString());
                retorno.Add(func.DepartamentoGerenciar.ToString());
            }
            return retorno;
        }

        [WebMethod]
        public List<String> select_projeto()
        {
            List<ProjetoDTO> projetos = ProjetoDAO.select();
            List<String> retorno = new List<String>();
            foreach (ProjetoDTO proj in projetos)
            {
                retorno.Add(proj.Id.ToString());
                retorno.Add(proj.Nome);
                retorno.Add(proj.Tipo);
                retorno.Add(proj.Verba);
                retorno.Add(proj.Departamento.ToString());
                retorno.Add(proj.CpfFuncionario.ToString());
            }
            return retorno;
        }

        [WebMethod]
        public List<String> select_funcionario()
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.select();
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Id.ToString());
                retorno.Add(func.Nome);
                retorno.Add(func.Salario.ToString());
                retorno.Add(func.Telefone);
                retorno.Add(func.Departamento.ToString());
                retorno.Add(func.Endereco);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> select_dependente()
        {
            List<DependenteDTO> dependentes = DependenteDAO.select();
            List<String> retorno = new List<String>();
            foreach (DependenteDTO dep in dependentes)
            {
                retorno.Add(dep.Id.ToString());
                retorno.Add(dep.Nome);
                retorno.Add(dep.Parentesco);
            }
            return retorno;
        }

        [WebMethod]
        public List<String> select_departamento()
        {
            List<DepartamentoDTO> departamentos = DepartamentoDAO.select();
            List<String> retorno = new List<String>();
            foreach (DepartamentoDTO dep in departamentos)
            {
                retorno.Add(dep.Id.ToString());
                retorno.Add(dep.Nome);
                retorno.Add(dep.Localizacao);
            }
            return retorno;
        }

        [WebMethod]
        public bool insert_projeto(ProjetoDTO projeto)
        {
            bool inclusao = ProjetoDAO.insert(projeto);
            return inclusao;
        }

        [WebMethod]
        public bool insert_funcionario(FuncionarioDTO funcionario)
        {
            bool inclusao = FuncionarioDAO.insert(funcionario);
            return inclusao;
        }

        [WebMethod]
        public bool insert_dependente(DependenteDTO dependente)
        {
            bool inclusao = DependenteDAO.insert(dependente);
            return inclusao;
        }

        [WebMethod]
        public bool insert_departamento(DepartamentoDTO departamento)
        {
            bool inclusao = DepartamentoDAO.insert(departamento);
            return inclusao;
        }

        [WebMethod]
        public bool update_projeto(ProjetoDTO projeto)
        {
            bool atualizacao = ProjetoDAO.update(projeto);
            return atualizacao;
        }

        [WebMethod]
        public bool update_funcionario(FuncionarioDTO funcionario)
        {
            bool atualizacao = FuncionarioDAO.update(funcionario);
            return atualizacao;
        }

        [WebMethod]
        public bool update_dependente(DependenteDTO dependente)
        {
            bool atualizacao = DependenteDAO.update(dependente);
            return atualizacao;
        }

        [WebMethod]
        public bool update_departamento(DepartamentoDTO departamento)
        {
            bool atualizacao = DepartamentoDAO.update(departamento);
            return atualizacao;
        }

        [WebMethod]
        public bool delete_projeto(int id)
        {
            bool exclusao = ProjetoDAO.delete(id);
            return exclusao;
        }

        [WebMethod]
        public bool delete_funcionario(int id)
        {
            bool exclusao = FuncionarioDAO.delete(id);
            return exclusao;
        }

        [WebMethod]
        public bool delete_dependente(int id)
        {
            bool exclusao = DependenteDAO.delete(id);
            return exclusao;
        }

        [WebMethod]
        public bool delete_departamento(int id)
        {
            bool exclusao = DepartamentoDAO.delete(id);
            return exclusao;
        }
    }
}   
