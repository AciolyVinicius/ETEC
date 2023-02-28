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
    /// Summary description for func_depart_maiorque
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class func_depart_maiorque : System.Web.Services.WebService
    {

        [WebMethod]
        public List<String> func_maior(int valor)
        {
            List<FuncionarioDTO> funcionarios = FuncionarioDAO.func_depart_maiorque(valor);
            List<String> retorno = new List<String>();
            foreach (FuncionarioDTO func in funcionarios)
            {
                retorno.Add(func.Nome);
                retorno.Add(func.Departamento.Id.ToString());
                retorno.Add(func.DepartamentoGerenciar.Id.ToString());
            }
            return retorno;
        }
    }
}
