﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quatro_Botões
{
    public partial class Excluir : Form
    {
        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Campo Excluir

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);//Coletando CPF
                                                          // Chamar Método
                MessageBox.Show(bd.Excluir(cpf, "pessoa"));
            }catch(Exception ex) 
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }// Fim do Botão Excluir

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Fim do Botão Cancelar
    }// Fim da Classe
}// Fim do Projeto
