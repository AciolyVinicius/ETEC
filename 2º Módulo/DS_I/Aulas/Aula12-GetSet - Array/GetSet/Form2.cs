using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GetSet
{
    public partial class Form2 : Form
    {
        int aux, cont;
        ArrayList nome = ClasseAcesso.Nome;
        ArrayList numero = ClasseAcesso.Numero;
        
        public Form2()
        {
            InitializeComponent();
            for (cont = 0; cont <= ClasseAcesso.ContArray(aux); cont = cont + 1)
            {
                lst_Lista.Items.Add(nome[cont]);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
            //if (aux != 0)
           // {
                
           // }
            //label que recebe o valor da primeira variavel
            //lbl_Nome.Text = ClasseAcesso.Str1;
            //label2 que recebe o valor da segunda variavel
            //lbl_Numero.Text = ClasseAcesso.Str2;
        }

        private void lst_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lst_Lista.SelectedIndex;
            lbl_Nome.Text = nome[index].ToString();
            lbl_Numero.Text = numero[index].ToString();
        }
    }
}
