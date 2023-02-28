using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWebService.DTO
{
    public class FuncionarioDTO
    {
        private int id;
        private String nome;
        private String endereco;
        private String telefone;
        private Double salario;
        private DepartamentoDTO departamento;
        private DepartamentoDTO departamentoGerenciar;

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

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
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

        public DepartamentoDTO DepartamentoGerenciar
        {
            get
            {
                return departamentoGerenciar;
            }

            set
            {
                departamentoGerenciar = value;
            }
        }
    }
}