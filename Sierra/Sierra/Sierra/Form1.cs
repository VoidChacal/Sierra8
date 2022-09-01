using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sierra
{
    public partial class Form1 : Form
    {
        //MUDAR AKI//
        public struct usuar
        {
            public int codigo;
            public string nome;
            public string nivel;
            public string login;
            public string senha;
        }
            
        static public usuar[] Usuarios = new usuar[10];
        static public int contUsuario = 0;
        //MUDAR AKI//
        public struct cliente
        {
            public int codigo;
            public string nome;
            public int cpf;
            public string endereco;
            public string bairro;
            public string cidade;
            public string uf;
            public int cep;
            public int telefone;
            public string email;

        }
        static cliente[] usuarios = new cliente[10];
        static public int contCliente = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            
        }

        private void novo_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcep.Clear();
            txtrg.Clear();
            txtendereco.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            txtuf.Clear();
            txtcep.Clear();
            txttelefone.Clear();
            txtemail.Clear();

        }

        private void txtrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcodigo.Text + txtnome.Text + txtcep.Text + txtendereco.Text + txtbairro.Text + txtcidade.Text + txtuf.Text + txtcep.Text + txttelefone.Text + txtemail.Text))
            {
                MessageBox.Show("Por favor complete todos os campos.", "Erro ao salvar!");
            }
            else
            {
                MessageBox.Show("Salvo com sucesso.", "Concluido!");
                string info1 = txtcodigo.Text;
                string info2 = txtnome.Text;
                string info3 = txtcep.Text;
                string info4 = txtrg.Text;
                string info5 = txtendereco.Text;
                string info6 = txtbairro.Text;
                string info7 = txtcidade.Text;
                string info8 = txtuf.Text;
                string info9 = txtcep.Text;
                string info10 = txttelefone.Text;
                string info11 = txtemail.Text;
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios novo = new Usuarios();
            novo.ShowDialog();
        }
    }
}
