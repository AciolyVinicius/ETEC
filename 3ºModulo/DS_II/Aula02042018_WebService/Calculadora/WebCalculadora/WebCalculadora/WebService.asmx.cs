using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebCalculadora
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Double Somar(Double num1, Double num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public Double Subtrair(Double num1, Double num2)
        {
            return num1 - num2;
        }

        [WebMethod]
        public Double Multiplicar(Double num1, Double num2)
        {
            return num1 * num2;
        }

        [WebMethod]
        public Double Dividir(Double num1, Double num2)
        {
            return num1 / num2;
        }
    }
}
