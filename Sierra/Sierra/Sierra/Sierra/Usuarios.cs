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

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Excluir_Click(object sender, EventArgs e)
        {

        }

        private void senhabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Excluir.Enabled = true;
            Alterar.Enabled = true;
        }

        private void Sair_Click(object sender, EventArgs e)
        {

        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void Alterar_Click(object sender, EventArgs e)
        {

        }

        private void Novo_Click(object sender, EventArgs e)
        {
          
                namebox.Text = "";
                nivelbox.Text = "";
                loginbox.Text = "";
                senhabox.Text = "";
                tipoEdicao = true;


            Anterior.Enabled = true;
            Proximo.Enabled = true;

            }

           
        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Anterior_Click(object sender, EventArgs e)
        {

        }

        private void Proximo_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
