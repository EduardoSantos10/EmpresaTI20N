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
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }// Fim do Construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// Fim do CPF

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }// Fim do Endereço

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);
                string nome = textBox2.Text;
                string telefone = textBox3.Text;
                string endereco = textBox4.Text;
                MessageBox.Show(bd.Inserir(cpf, nome, telefone, endereco));//Insere dados no BD
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }// Fim do Botão Cadastrar
            
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Fim do Cancelar
    }
}
