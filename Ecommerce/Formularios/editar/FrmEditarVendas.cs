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

            VendaProduto vp = new VendaProduto();
            dtgridVendaProduto.DataSource = vp.PreencherGrid();
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
                // Captura os valores da linha selecionada
                int id = Convert.ToInt32(dtgridProdutos.Rows[e.RowIndex].Cells["Id"].Value);
                string descricao = dtgridProdutos.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                decimal precoUnitario = Convert.ToDecimal(dtgridProdutos.Rows[e.RowIndex].Cells["PrecoUnitario"].Value);
                int quantidade = 1; // Por padrão, 1 item é adicionado

                // Cria o objeto de venda
                VendaProduto p = new VendaProduto
                {
                    VendaId = int.Parse(txtId.Text), // Certifique-se de que txtId tem o ID da venda
                    ProdutoId = id,
                    PrecoUnitario = precoUnitario,
                    Quantidade = quantidade
                };

                // Insere no banco de dados
                p.Inserir();

                // Mensagem de sucesso
                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso");

                // Inicializa a lista se for nula
                List<VendaProduto> listaVendaProduto;

                if (dtgridVendaProduto.DataSource == null || !(dtgridVendaProduto.DataSource is List<VendaProduto>))
                {
                    listaVendaProduto = new List<VendaProduto>();
                }
                else
                {
                    // Obtém a lista existente
                    listaVendaProduto = (List<VendaProduto>)dtgridVendaProduto.DataSource;
                }

                // Adiciona o novo produto à lista
                listaVendaProduto.Add(p);

                // Atualiza o DataGridView
                dtgridVendaProduto.DataSource = null;
                dtgridVendaProduto.DataSource = listaVendaProduto;
            }
        }






        private void dtgridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgridVendaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                // Obtém o ID da venda selecionada na grid
                int vendaId = Convert.ToInt32(dtgridVendaProduto.Rows[e.RowIndex].Cells["VendaId"].Value);

                // Confirmação do usuário para exclusão
                DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir esta venda?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        // Cria uma instância de VendaProduto e define o ID
                        VendaProduto vendaProduto = new VendaProduto { VendaId = vendaId };

                        // Chama o método de exclusão
                        vendaProduto.Excluir();
                        dtgridVendaProduto.DataSource = vendaProduto.PreencherGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
