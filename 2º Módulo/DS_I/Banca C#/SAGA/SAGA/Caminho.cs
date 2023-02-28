using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAGA
{
    class Caminho
    {
        public String Route()
        {
            String route = "SERVER=localhost;DATABASE=mydb;UID=root;PASSWORD=root";            
            return route;
        }
    }
}
