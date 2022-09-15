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
    public partial class Cadastrar : Form
    {
        bool tipoEdicao = false;
        int atual = 0;

        private void habilitarEdicao()
        {
            txtcodigo.Enabled = false;
            txtbairro.Enabled = true;
            txtcidade.Enabled = true;
            txtcep.Enabled = true;
            txtrg.Enabled = true;
            txtendereco.Enabled = true;
            txtuf.Enabled = true;
            txttelefone.Enabled = true;
            txtemail.Enabled = true;
            txtcpf.Enabled = true;
            txtnome.Enabled = true;
            salvar.Enabled = true;
            cancelar.Enabled = false;
            anterior.Enabled = false;
            proximo.Enabled = false;
            novo.Enabled = false;
            alterar.Enabled = false;
            pesquisa.Enabled = false;
            imprimir.Enabled = false;
            sair.Enabled = false;

        }
        private void desabilitarEdicao()
        {
            txtcodigo.Enabled = false;
            txtbairro.Enabled = false;
            txtcidade.Enabled = false;
            txtcep.Enabled = false;
            txtrg.Enabled = false;
            txtendereco.Enabled = false;
            txtuf.Enabled = false;
            txttelefone.Enabled = false;
            txtemail.Enabled = false;
            txtcpf.Enabled = false;
            txtnome.Enabled = false;
            salvar.Enabled = false;
            cancelar.Enabled = false;
            anterior.Enabled = true;
            proximo.Enabled = true;
            novo.Enabled = true;
            alterar.Enabled = true;
            pesquisa.Enabled = true;
            imprimir.Enabled = true;
            sair.Enabled = true;
        }
        private void mostrardados()
        {
            txtcodigo.Text = Form1.Cliente[atual].codigo.ToString();
            txtcep.Text = Form1.Cliente[atual].cep.ToString();
            txtcpf.Text = Form1.Cliente[atual].cpf.ToString();
            txtrg.Text = Form1.Cliente[atual].rg.ToString();
            txttelefone.Text = Form1.Cliente[atual].telefone.ToString();
            txtcidade.Text = Form1.Cliente[atual].cidade;
            txtemail.Text = Form1.Cliente[atual].email;
            txtendereco.Text = Form1.Cliente[atual].endereco;
            txtbairro.Text = Form1.Cliente[atual].bairro;
            txtuf.Text = Form1.Cliente[atual].uf;

        }
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            if (Form1.contCliente < 10)
            {
                txtcodigo.Text = (Form1.contCliente + 1).ToString();
                txtnome.Text = "";
                txtcpf.Text = "";
                txtcep.Text = "";
                txtemail.Text = "";
                txtendereco.Text = "";
                txttelefone.Text = "";
                txtuf.Text = "";
                txtrg.Text = "";
                txtbairro.Text = "";
                txtcidade.Text = "";
                habilitarEdicao();
                tipoEdicao = true;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (tipoEdicao)
            {
                Form1.Cliente[Form1.contCliente].codigo = int.Parse(txtcodigo.Text);
                Form1.Cliente[Form1.contCliente].rg = int.Parse(txtrg.Text);
                Form1.Cliente[Form1.contCliente].nome = txtnome.Text;
                Form1.Cliente[Form1.contCliente].bairro = txtbairro.Text;
                Form1.Cliente[Form1.contCliente].cep = int.Parse(txtcep.Text);
                Form1.Cliente[Form1.contCliente].cidade = txtcidade.Text;
                Form1.Cliente[Form1.contCliente].cpf = int.Parse(txtcpf.Text);
                Form1.Cliente[Form1.contCliente].endereco = txtendereco.Text;
                Form1.Cliente[Form1.contCliente].email = txtemail.Text;
                Form1.Cliente[Form1.contCliente].telefone = int.Parse(txttelefone.Text);
                Form1.Cliente[Form1.contCliente].uf = txtuf.Text;

            }
            else
            {
                Form1.Cliente[Form1.contCliente].cep = int.Parse(txtcep.Text);
                Form1.Cliente[Form1.contCliente].cpf = int.Parse(txtcpf.Text);
                Form1.Cliente[Form1.contCliente].telefone = int.Parse(txttelefone.Text);
                Form1.Cliente[Form1.contCliente].rg = int.Parse(txtrg.Text);
                Form1.Cliente[Form1.contCliente].nome = txtnome.Text;
                Form1.Cliente[Form1.contCliente].bairro = txtbairro.Text;
                Form1.Cliente[Form1.contCliente].cidade = txtcidade.Text;
                Form1.Cliente[Form1.contCliente].email = txtemail.Text;
                Form1.Cliente[Form1.contCliente].endereco = txtendereco.Text;
                Form1.Cliente[Form1.contCliente].uf = txtuf.Text;
            }
            desabilitarEdicao();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if(Form1.contCliente > 0)
            {
                txtnome.Text = "";
                txtcpf.Text = "";
                txtcep.Text = "";
                txtemail.Text = "";
                txtendereco.Text = "";
                txttelefone.Text = "";
                txtuf.Text = "";
                txtrg.Text = "";
                txtbairro.Text = "";
                txtcidade.Text = "";
                mostrardados();
            }
        }

        private void proximo_Click(object sender, EventArgs e)
        {
            if (atual < Form1.contCliente - 1)
            {
                atual++;
                mostrardados();
            }
            else MessageBox.Show("Fim de arquivo");
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            if (Form1.contCliente > 0)
            {
                habilitarEdicao();
                tipoEdicao = false;
            }
            else MessageBox.Show("Nenhum arquivo para alterar", "ERRO");
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                mostrardados();
            }
            else MessageBox.Show("Início do arquivo!");
        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pesquisa_Click(object sender, EventArgs e)
        {
            painel.Visible = true;
        }

        private void procurar_Click(object sender, EventArgs e)
        {
            int x;
            for(x = 0; x < Form1.contCliente; x++)
            {
                if(Form1.Cliente[x].nome.IndexOf(textpesquisa.Text) >= 0)
                {
                    atual = x;
                    mostrardados();
                    break;
                }
                if (x >= Form1.contUsuario)
                {
                    MessageBox.Show(textpesquisa, "Não encontrado!", "ERRO");
                }
                painel.Visible = false;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            desabilitarEdicao();
            mostrardados();
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            Preview1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados;
            Graphics objImpressao = e.Graphics;

            Dados = "FICHA DO USUÁRIO" + (char)10 + (char)10;
            Dados = Dados + "----------------------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "Código: " + txtcodigo.Text + (char)10 + (char)10;
            Dados = Dados + "Nome: " + txtnome.Text + (char)10 + (char)10;
            Dados = Dados + "CPF: " + txtcpf.Text + (char)10 + (char)10;
            Dados = Dados + "RG: " + txtrg.Text + (char)10 + (char)10;
            Dados = Dados + "Endereço: " + txtendereco.Text;
            Dados = Dados + "Bairro: " + txtbairro.Text;
            Dados = Dados + "Cidade: " + txtcidade.Text;
            Dados = Dados + "UF: " + txtuf.Text;
            Dados = Dados + "CEP: " + txtcep.Text;
            Dados = Dados + "Email: " + txtemail.Text;
            objImpressao.DrawString(Dados, new Font("Segoe Print", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
