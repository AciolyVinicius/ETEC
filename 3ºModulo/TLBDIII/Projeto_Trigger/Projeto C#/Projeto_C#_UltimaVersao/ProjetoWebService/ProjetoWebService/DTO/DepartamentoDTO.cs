using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebService.DTO
{
    public class DepartamentoDTO
    {
        private int id;
        private String nome;
        private String localizacao;

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

        public string Localizacao
        {
            get
            {
                return localizacao;
            }

            set
            {
                localizacao = value;
            }
        }
    }
}