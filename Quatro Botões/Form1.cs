using System;
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
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            atu = new Atualizar();
            exc = new Excluir();
        }// Construtor da Tela

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }// Fim do Botão Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            con = new Consultar();//Consultar ATUALIZADAS!!!
            con.ShowDialog();
        }// Fim do Botão Consultar

        private void button4_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }// Fim do Botão Atualizar

        private void button3_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }// Fim do Botão Excluir
    }
}
