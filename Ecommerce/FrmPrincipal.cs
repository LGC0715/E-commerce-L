using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ecommerce.Entidade;
using Ecommerce.Formularios;

namespace Ecommerce
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
           // CarregarDadosDashboard();
        }

       /* private void CarregarDadosDashboard()
        {
            // Simula dados de exemplo - você pode substituir pela lógica de banco de dados
            var vendas = ObterVendasDoDia();
            var produtosMaisVendidos = ObterProdutosMaisVendidos();

            // Exibir Total de Vendas
            lblTotalVendas.Text = $"Total de Vendas do Dia: R$ {vendas.Sum(v => v.Valor):F2}";

            // Exibir Produtos Mais Vendidos no DataGridView
            dgvProdutosMaisVendidos.DataSource = produtosMaisVendidos
                .Select(p => new { p.Nome, p.Quantidade })
                .ToList();
        }
       */
        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos s = new FrmProdutos();
            s.ShowDialog();
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas s = new FrmVendas();
            s.ShowDialog();
        }

        private void vENDADEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendasProdutos s = new FrmVendasProdutos();
            s.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cADASTRARNOVOUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // FrmUsuario s = new FrmUsuario();
            //s.ShowDialog();
        }

        // Simulação de dados para o dashboard
        /* private List<Venda> ObterVendasDoDia()
         {
             return new List<Venda>
             {
                 new Venda { Id = 1, Data = DateTime.Now, Valor = 100.50 },
                 new Venda { Id = 2, Data = DateTime.Now, Valor = 200.00 }
             };
         }

         private List<Produto> ObterProdutosMaisVendidos()
         {
             return new List<Produto>
             {
                 new Produto { Nome = "Produto A", Quantidade = 10 },
                 new Produto { Nome = "Produto B", Quantidade = 8 },
                 new Produto { Nome = "Produto C", Quantidade = 6 }
             };
         }
        */
    }
}
