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
    public partial class Menu : Form
    {   
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
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
