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
    public partial class Produtos : Form
    {
        bool edicao = false;
        int atual = 0;
        private void AtivarEdicao()
        {
            textcodigo.Enabled = false;
            textdescricao.Enabled = true;
            textunidade.Enabled = true;
            textvenda.Enabled = true;
            textquantidade.Enabled = true;
            textcusto.Enabled = true;
            Salvar.Enabled = true;
            Cancelar.Enabled = false;
            Anterior.Enabled = false;
            Proximo.Enabled = false;
            Novo.Enabled = false;
            Pesquisa.Enabled = false;
            Imprimir.Enabled = false;
            Sair.Enabled = false;
        }
        private void desativarEdicao()
        {
            textcodigo.Enabled = false;
            textcusto.Enabled = false;
            textdescricao.Enabled = false;
            textvenda.Enabled = false;
            textquantidade.Enabled = false;
            textunidade.Enabled = false;
            Salvar.Enabled = false;
            Cancelar.Enabled = false;
            Anterior.Enabled = true;
            Proximo.Enabled = true;
            Novo.Enabled = true;
            Alterar.Enabled = true;
            Pesquisa.Enabled = true;
            Imprimir.Enabled = true;
            Sair.Enabled = true;

        }
        private void mostrardados()
        {
            textcodigo.Text = Form1.Produtos[atual].codigo.ToString();
            textcusto.Text = Form1.Produtos[atual].pdc.ToString();
            textvenda.Text = Form1.Produtos[atual].pdv.ToString();
            textdescricao.Text = Form1.Produtos[atual].descricao;
            textunidade.Text = Form1.Produtos[atual].unidade.ToString();
            textquantidade.Text = Form1.Produtos[atual].quantidade.ToString();
        }
        public Produtos()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                mostrardados();
            }
            else MessageBox.Show("Início do arquivo!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            painel.Visible = true;
        }

        private void Proximo_Click(object sender, EventArgs e)
        {
            if (atual < Form1.contProdutos - 1)
            {
                atual++;
                mostrardados();
            }
            else MessageBox.Show("Fim do arquivo!");
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            if (Form1.contProdutos < 10)
            {
                textcodigo.Text = (Form1.contProdutos + 1).ToString();
                textdescricao.Text = "";
                textcusto.Text = "";
                textquantidade.Text = "";
                textunidade.Text = "";
                textvenda.Text = "";
                AtivarEdicao();
                edicao = true;
            }
            else MessageBox.Show("Arquivo cheio!");
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            if (Form1.contProdutos > 0)
            {
                AtivarEdicao();
                edicao = false;
            }
            else MessageBox.Show("Arquivo vazio!");
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (edicao)
            {
                Form1.Produtos[Form1.contProdutos].codigo = int.Parse(textcodigo.Text);
                Form1.Produtos[Form1.contProdutos].descricao = textdescricao.Text;
                Form1.Produtos[Form1.contProdutos].pdv = int.Parse(textvenda.Text);
                Form1.Produtos[Form1.contProdutos].pdc = int.Parse(textcusto.Text);
                Form1.Produtos[Form1.contProdutos].unidade = int.Parse(textunidade.Text);
                Form1.Produtos[Form1.contProdutos].quantidade = int.Parse(textquantidade.Text);
                atual = Form1.contProdutos++;
            }
            else
            {
                Form1.Produtos[atual].descricao = textdescricao.Text;
                Form1.Produtos[atual].pdv = int.Parse(textvenda.Text);
                Form1.Produtos[atual].pdc = int.Parse(textcusto.Text);
                Form1.Produtos[atual].unidade = int.Parse(textunidade.Text);
                Form1.Produtos[atual].quantidade = int.Parse(textquantidade.Text);

            }
            desativarEdicao();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            painel.Visible = false;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (Form1.contProdutos > 0)
            {
                Form1.Produtos[atual].descricao = "";
                Form1.Produtos[atual].unidade = int.Parse("");
                Form1.Produtos[atual].pdv = int.Parse("");
                Form1.Produtos[atual].pdc = int.Parse("");
                Form1.Produtos[atual].quantidade = int.Parse("");
                mostrardados();

            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            AtivarEdicao();
            mostrardados();
        }

        private void procurar_Click(object sender, EventArgs e)
        {
            int x;
            for (x = 0; x < Form1.contProdutos; x++)
            {
                if (Form1.Produtos[x].descricao.IndexOf(textpesquisa.Text) >= 0)
                {
                    atual = x;
                    mostrardados();
                    break;
                }
            }
            if (x >= Form1.contProdutos)
            {
                MessageBox.Show(textpesquisa, "Não encontrado!", "Erro");
            }
            painel.Visible = false;
        }

        private void textpesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados;
            Graphics objImpressao = e.Graphics;

            Dados = "FICHA DOS PRODUTOS" + (char)10 + (char)10;
            Dados = Dados + "----------------------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "Código: " + textcodigo.Text + (char)10 + (char)10;
            Dados = Dados + "Descrição: " + textdescricao.Text + (char)10 + (char)10;
            Dados = Dados + "Quantidade: " + textquantidade.Text + (char)10 + (char)10;
            Dados = Dados + "Preço de custo: " + textcusto.Text + (char)10 + (char)10;
            Dados = Dados + "Preço de venda: " + textvenda.Text;
            objImpressao.DrawString(Dados, new Font("Segoe Print", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void textcusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            desativarEdicao();
            mostrardados();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            Preview.ShowDialog();
        }
    }
}
