using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GetSet
{
    class ClasseAcesso
    {
        private static ArrayList nome = new ArrayList();
        private static ArrayList numero = new ArrayList();
        //private static int cont = 0;

        public static ArrayList Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome.Add(value);
            }
        }

        public static ArrayList Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero.Add(value);
            }
        }

        public static int ContArray(int cont)
        {
            cont = nome.Count - 1;
            return cont;
        }
        
        /*//variavel private e static para ser chamada sem a instancia. Apenas colocando o nome da classe.variavel/método
        private static String str1 = "";
        private static String str2 = "";

        //Get/Set para pegar e setar o valor das variaves
        public static String Str1
        {
            get { return str1; }
            set { str1 = value; }
        }

        //Get/Set para pegar e setar o valor das variaves
       public static String Str2
       {
           get { return str2; }
           set { str2 = value; }
       }*/

      
    }
}
