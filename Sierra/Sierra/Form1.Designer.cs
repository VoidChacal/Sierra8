
namespace Sierra
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printUsuario = new System.Drawing.Printing.PrintDocument();
            this.RelUsuar = new System.Windows.Forms.PrintPreviewDialog();
            this.CadUsuario = new System.Windows.Forms.Button();
            this.CadClientes = new System.Windows.Forms.Button();
            this.CadProdutos = new System.Windows.Forms.Button();
            this.RelUsuario = new System.Windows.Forms.Button();
            this.RelClientes = new System.Windows.Forms.Button();
            this.RelProdutos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printClientes = new System.Drawing.Printing.PrintDocument();
            this.printProdutos = new System.Drawing.Printing.PrintDocument();
            this.PreviewClientes = new System.Windows.Forms.PrintPreviewDialog();
            this.PreviewProdutos = new System.Windows.Forms.PrintPreviewDialog();
            this.Sair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.clientesToolStripMenuItem,
            this.toolStripSeparator2,
            this.produtosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 82);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // printUsuario
            // 
            this.printUsuario.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // RelUsuar
            // 
            this.RelUsuar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.RelUsuar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.RelUsuar.ClientSize = new System.Drawing.Size(400, 300);
            this.RelUsuar.Document = this.printUsuario;
            this.RelUsuar.Enabled = true;
            this.RelUsuar.Icon = ((System.Drawing.Icon)(resources.GetObject("RelUsuar.Icon")));
            this.RelUsuar.Name = "printPreviewDialog1";
            this.RelUsuar.Visible = false;
            this.RelUsuar.Load += new System.EventHandler(this.RelUsuar_Load);
            // 
            // CadUsuario
            // 
            this.CadUsuario.BackColor = System.Drawing.Color.Black;
            this.CadUsuario.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.CadUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.CadUsuario.Location = new System.Drawing.Point(116, 146);
            this.CadUsuario.Name = "CadUsuario";
            this.CadUsuario.Size = new System.Drawing.Size(175, 74);
            this.CadUsuario.TabIndex = 2;
            this.CadUsuario.Text = "Usuario";
            this.CadUsuario.UseVisualStyleBackColor = false;
            this.CadUsuario.Click += new System.EventHandler(this.CadUsuario_Click);
            // 
            // CadClientes
            // 
            this.CadClientes.BackColor = System.Drawing.Color.Black;
            this.CadClientes.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.CadClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.CadClientes.Location = new System.Drawing.Point(116, 242);
            this.CadClientes.Name = "CadClientes";
            this.CadClientes.Size = new System.Drawing.Size(175, 74);
            this.CadClientes.TabIndex = 3;
            this.CadClientes.Text = "Clientes";
            this.CadClientes.UseVisualStyleBackColor = false;
            this.CadClientes.Click += new System.EventHandler(this.CadClientes_Click);
            // 
            // CadProdutos
            // 
            this.CadProdutos.BackColor = System.Drawing.Color.Black;
            this.CadProdutos.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.CadProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.CadProdutos.Location = new System.Drawing.Point(116, 334);
            this.CadProdutos.Name = "CadProdutos";
            this.CadProdutos.Size = new System.Drawing.Size(175, 74);
            this.CadProdutos.TabIndex = 4;
            this.CadProdutos.Text = "Produtos";
            this.CadProdutos.UseVisualStyleBackColor = false;
            this.CadProdutos.Click += new System.EventHandler(this.CadProdutos_Click);
            // 
            // RelUsuario
            // 
            this.RelUsuario.BackColor = System.Drawing.Color.Black;
            this.RelUsuario.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.RelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.RelUsuario.Location = new System.Drawing.Point(625, 146);
            this.RelUsuario.Name = "RelUsuario";
            this.RelUsuario.Size = new System.Drawing.Size(175, 74);
            this.RelUsuario.TabIndex = 5;
            this.RelUsuario.Text = "Usuario";
            this.RelUsuario.UseVisualStyleBackColor = false;
            this.RelUsuario.Click += new System.EventHandler(this.RelUsuario_Click);
            // 
            // RelClientes
            // 
            this.RelClientes.BackColor = System.Drawing.Color.Black;
            this.RelClientes.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.RelClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.RelClientes.Location = new System.Drawing.Point(625, 242);
            this.RelClientes.Name = "RelClientes";
            this.RelClientes.Size = new System.Drawing.Size(175, 74);
            this.RelClientes.TabIndex = 6;
            this.RelClientes.Text = "Clientes";
            this.RelClientes.UseVisualStyleBackColor = false;
            this.RelClientes.Click += new System.EventHandler(this.RelClientes_Click);
            // 
            // RelProdutos
            // 
            this.RelProdutos.BackColor = System.Drawing.Color.Black;
            this.RelProdutos.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.RelProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.RelProdutos.Location = new System.Drawing.Point(625, 334);
            this.RelProdutos.Name = "RelProdutos";
            this.RelProdutos.Size = new System.Drawing.Size(175, 74);
            this.RelProdutos.TabIndex = 7;
            this.RelProdutos.Text = "Produtos";
            this.RelProdutos.UseVisualStyleBackColor = false;
            this.RelProdutos.Click += new System.EventHandler(this.RelProdutos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(105, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(614, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 64);
            this.label2.TabIndex = 9;
            this.label2.Text = "Relatorios";
            // 
            // printClientes
            // 
            this.printClientes.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printClientes_PrintPage);
            // 
            // printProdutos
            // 
            this.printProdutos.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printProdutos_PrintPage);
            // 
            // PreviewClientes
            // 
            this.PreviewClientes.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PreviewClientes.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PreviewClientes.ClientSize = new System.Drawing.Size(400, 300);
            this.PreviewClientes.Document = this.printClientes;
            this.PreviewClientes.Enabled = true;
            this.PreviewClientes.Icon = ((System.Drawing.Icon)(resources.GetObject("PreviewClientes.Icon")));
            this.PreviewClientes.Name = "printPreviewDialog1";
            this.PreviewClientes.Visible = false;
            // 
            // PreviewProdutos
            // 
            this.PreviewProdutos.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PreviewProdutos.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PreviewProdutos.ClientSize = new System.Drawing.Size(400, 300);
            this.PreviewProdutos.Document = this.printProdutos;
            this.PreviewProdutos.Enabled = true;
            this.PreviewProdutos.Icon = ((System.Drawing.Icon)(resources.GetObject("PreviewProdutos.Icon")));
            this.PreviewProdutos.Name = "printPreviewDialog1";
            this.PreviewProdutos.Visible = false;
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Black;
            this.Sair.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.Sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.Sair.Location = new System.Drawing.Point(366, 361);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(175, 74);
            this.Sair.TabIndex = 10;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(196)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(366, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 64);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sierra8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelProdutos);
            this.Controls.Add(this.RelClientes);
            this.Controls.Add(this.RelUsuario);
            this.Controls.Add(this.CadProdutos);
            this.Controls.Add(this.CadClientes);
            this.Controls.Add(this.CadUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printUsuario;
        private System.Windows.Forms.PrintPreviewDialog RelUsuar;
        private System.Windows.Forms.Button CadUsuario;
        private System.Windows.Forms.Button CadClientes;
        private System.Windows.Forms.Button CadProdutos;
        private System.Windows.Forms.Button RelUsuario;
        private System.Windows.Forms.Button RelClientes;
        private System.Windows.Forms.Button RelProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printClientes;
        private System.Drawing.Printing.PrintDocument printProdutos;
        private System.Windows.Forms.PrintPreviewDialog PreviewClientes;
        private System.Windows.Forms.PrintPreviewDialog PreviewProdutos;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label3;
    }
}

