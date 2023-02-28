using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebService.DTO
{
    public class ProjetoDTO
    {
        private int id;
        private String nome;
        private String tipo;
        private String verba;
        private int cpfFuncionario;
        private DepartamentoDTO departamento;

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

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Verba
        {
            get
            {
                return verba;
            }

            set
            {
                verba = value;
            }
        }

        public int CpfFuncionario
        {
            get
            {
                return cpfFuncionario;
            }

            set
            {
                cpfFuncionario = value;
            }
        }

        public DepartamentoDTO Departamento
        {
            get
            {
                return departamento;
            }

            set
            {
                departamento = value;
            }
        }
    }
}