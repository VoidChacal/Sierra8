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
            public int rg;
            public int telefone;
            public string email;

        }
        static public cliente[] Cliente = new cliente[10];
        static public int contCliente = 0;

        public struct produtos
        {
            public int codigo;
            public string descricao;
            public int unidade;
            public int quantidade;
            public int pdc;
            public int pdv;

        }
        static public produtos[] Produtos = new produtos[10];
        static public int contProdutos = 0;
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
           

        }

        private void txtrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios novo = new Usuarios();
            novo.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txttelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;


            while (cabecalho)
            {
                Dados = "                                   RELATÓRIO DOS USUÁRIOS" + (char)10;
                Dados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + "Pág:  " + pag.ToString("00") + (char)10;
                Dados += "--------------------------------------------------------------------------------" + (char)10;
                Dados += "Código Nome                                                               Nível Login" + (char)10;
                Dados += "--------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                itens = true;
                while (itens)
                {
                    Dados += Usuarios[i].codigo.ToString("000000") + " " + Usuarios[i].nome.PadRight(40) + " " + Usuarios[i].nivel + "   " + Usuarios[i].login + (char)10;
                    linha++;
                    i++;
                    if (linha >= 64)
                    {
                        itens = false;
                        Dados += (char)12;
                    }
                    if (i >= contUsuario)
                    {
                        itens = false;
                        cabecalho = false;
                    }
                }
            }
            objImpressao.DrawString(Dados, new Font("Segoe Print", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
