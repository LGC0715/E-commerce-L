using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecommerce.Classes;
using Ecommerce.Formularios.cadastrar;
using Ecommerce.Formularios.editar;

namespace Ecommerce.Formularios
{
    public partial class FrmProdutos : Form
    {
        

        public FrmProdutos()
        {
            
            InitializeComponent();
            Produto u = new Produto();
            dtGridProdutos.DataSource = u.PreencherGrid();
        }


        private void btnadd_disc_Click(object sender, EventArgs e)
        {

            FrmCadastrarProdutos cadastrar = new FrmCadastrarProdutos();
            cadastrar.FormClosed += Fechou_Produto_FormClosed;

            // Abre o formulário de cadastro como modal
            cadastrar.ShowDialog();
        }
        private void Fechou_Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Produto u = new Produto();
            dtGridProdutos.DataSource = u.PreencherGrid();
        }
        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Produto u = new Produto();
            dtGridProdutos.DataSource = u.Pesquisar(txtpesquisa.Text);
        }

        private void dtGridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                dtGridProdutos.Rows[e.RowIndex].Cells[0].Value);

              FrmEditarProdutos editar = new FrmEditarProdutos(id);

                // Inscreve-se no evento
               editar.FormClosed += Fechou_Produto_FormClosed;

                editar.ShowDialog(); // Abre o formulário como um diálogo modal

            }
        }
        private void btnadd_produto_Click(object sender, EventArgs e)
        {

            FrmCadastrarProdutos d = new FrmCadastrarProdutos();
            d.FormClosed += Fechou_Produto_FormClosed;
            d.ShowDialog();
        }

        private void dtGridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
