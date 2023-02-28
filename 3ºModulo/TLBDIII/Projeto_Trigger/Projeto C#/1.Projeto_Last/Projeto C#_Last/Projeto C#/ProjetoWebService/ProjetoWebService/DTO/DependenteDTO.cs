using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebService.DTO
{
    public class DependenteDTO
    {
        private int id;
        private String nome;
        private String parentesco;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Parentesco
        {
            get
            {
                return parentesco;
            }

            set
            {
                parentesco = value;
            }
        }
    }
}