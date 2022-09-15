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
    public partial class Usuarios : Form
    {
        bool tipoEdicao = false;
        int atual = 0;
        private void habilitaEdicao()
        {
            textcodigo.Enabled = false;
            textname.Enabled = true;
            textlevel.Enabled = true;
            textlogin.Enabled = true;
            textsenha.Enabled = true;
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
        private void desabilitaEdicao()
        {
            textcodigo.Enabled = false;
            textname.Enabled = false;
            textlevel.Enabled = false;
            textlogin.Enabled = false;
            textsenha.Enabled = false;
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
        private void exibirdados()
        {
            textcodigo.Text = Form1.Usuarios[atual].codigo.ToString();
            textname.Text = Form1.Usuarios[atual].nome;
            textlevel.Text = Form1.Usuarios[atual].nivel;
            textlogin.Text = Form1.Usuarios[atual].login;
            textsenha.Text = Form1.Usuarios[atual].senha;
        }
        public Usuarios()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            desabilitaEdicao();
            exibirdados();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            desabilitaEdicao();
            exibirdados();
        }

        private void pesquisa_Click(object sender, EventArgs e)
        {
            painel.Visible = true;

            
        }

        private void proximo_Click(object sender, EventArgs e)
        {
            if (atual < Form1.contUsuario - 1)
            {
                atual++;
                exibirdados();
            }
            else MessageBox.Show("Fim de arquivo1");
        }

        private void novo_Click(object sender, EventArgs e)
        {
            if (Form1.contUsuario < 10)
            {
                textcodigo.Text = (Form1.contUsuario + 1).ToString();
                textname.Text = "";
                textlevel.Text = "";
                textlogin.Text = "";
                textsenha.Text = "";
                habilitaEdicao();
                tipoEdicao = true;
            }
            else MessageBox.Show("Arquivo cheio!");
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            if (Form1.contUsuario > 0)
            {
                habilitaEdicao();
                tipoEdicao = false;
            }
            else MessageBox.Show("Arquivo vazio!");
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (Form1.contUsuario > 0)
            {
                Form1.Usuarios[atual].nome = "";
                Form1.Usuarios[atual].nivel = "";
                Form1.Usuarios[atual].login = "";
                Form1.Usuarios[atual].senha = "";
                exibirdados();
                
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            Preview1.ShowDialog();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            if (tipoEdicao)
            {
                Form1.Usuarios[Form1.contUsuario].codigo = int.Parse(textcodigo.Text);
                Form1.Usuarios[Form1.contUsuario].nome = textname.Text;
                Form1.Usuarios[Form1.contUsuario].nivel = textlevel.Text;
                Form1.Usuarios[Form1.contUsuario].login = textlogin.Text;
                Form1.Usuarios[Form1.contUsuario].senha = textsenha.Text;
                atual = Form1.contUsuario++;
            }
            else
            {
                Form1.Usuarios[atual].nome = textname.Text;
                Form1.Usuarios[atual].login = textlogin.Text;
                Form1.Usuarios[atual].nivel = textlevel.Text;
                Form1.Usuarios[atual].senha = textsenha.Text;
                
            }
            desabilitaEdicao();
            
        }

        private void textsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                exibirdados();
            }
            else MessageBox.Show("Início do arquivo!");
        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void procurar_Click(object sender, EventArgs e)
        {
            int x;
            for (x = 0; x < Form1.contUsuario; x++)
            {
                if( Form1.Usuarios[x].nome.IndexOf(textpesquisa.Text) >= 0)
                {
                    atual = x;
                    exibirdados();
                    break;
                }
            }
            if (x >= Form1.contUsuario)
            {
                MessageBox.Show(textpesquisa,"Não encontrado!", "Erro");
            }
            painel.Visible = false;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            painel.Visible = false;
        }

        private void Documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         }

        private void Documento1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Dados;
            Graphics objImpressao = e.Graphics;

            Dados = "FICHA DO USUÁRIO" + (char)10 + (char)10;
            Dados = Dados + "----------------------------------------------------------------------------" + (char)10 + (char)10;
            Dados = Dados + "Código: " + textcodigo.Text + (char)10 + (char)10;
            Dados = Dados + "Nome: " + textname.Text + (char)10 + (char)10;
            Dados = Dados + "Nível: " + textlevel.Text + (char)10 + (char)10;
            Dados = Dados + "Login: " + textlogin.Text;
            objImpressao.DrawString(Dados, new Font("Segoe Print", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void Documento2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void Preview1_Load(object sender, EventArgs e)
        {

        }
    }
}
