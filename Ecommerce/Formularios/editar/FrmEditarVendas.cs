using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecommerce.Classes;
using MySqlConnector;

namespace Ecommerce.Formularios.editar
{
    public partial class FrmEditarVendas : Form
    {
     
        public FrmEditarVendas(int id)
        {
            InitializeComponent();
            Venda p = new Venda();
            p.PesquisarPorId(id);
            txtId.Text = p.Id.ToString();
            txtDataVenda.Text = p.DataVenda.ToString();
            txtTotal.Text = p.Total.ToString();
            cbxformapag.SelectedItem = p.FormaPagamento;
            txtDesconto.Text = p.Desconto.ToString();
            txtStatusVenda.Text = p.StatusVenda.ToString();
            p = null;

            Produto u = new Produto();
            dtgridProdutos.DataSource = u.PreencherGrid();

            VendaProduto vp = new VendaProduto();
            dtgridVendaProduto.DataSource = vp.PreencherGrid();

            //No grid de produtos, criar o cell double clique, pegar o Id do produto clicado

            //com o Id vc salva esse produto na tabela VendaProduto

            //ao finalizar vc usa o preenchergrid do VendaProduto


           
        }


        private void FrmEditarVendas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Venda p = new Venda();
            p.Id = Convert.ToInt32(txtId.Text);
            p.Excluir();
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Venda p = new Venda();
            p.DataVenda = DateTime.Parse(txtDataVenda.Text);
            p.Total = Convert.ToDecimal(txtTotal.Text); 
            p.FormaPagamento = cbxformapag.Text;
            p.Desconto = Convert.ToInt32(txtDesconto.Text);
            p.StatusVenda = txtStatusVenda.Text;

            p.Editar();
            p = null;
            this.Close();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Produto u = new Produto();
            dtgridProdutos.DataSource = u.Pesquisar(txtpesquisa.Text);
        }

        private void dtgridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                dtgridProdutos.Rows[e.RowIndex].Cells[0].Value);

                VendaProduto p = new VendaProduto();
                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;
                p.PrecoUnitario = Convert.ToDecimal(txtPreco.Text);
                p.Estoque = Convert.ToInt32(txtEstoque.Text);
                p.Inserir();
                MessageBox.Show("Sucesso", "Cadastrado com sucesso");
                Close();

         
    }

            
        }

        private void dtgridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
