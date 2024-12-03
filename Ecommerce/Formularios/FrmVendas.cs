using System;
using System.Data;
using System.Windows.Forms;
using Ecommerce.Classes;
using Ecommerce.Formularios.cadastrar;
using Ecommerce.Formularios.editar;

namespace Ecommerce.Formularios
{
    public partial class FrmVendas : Form
    {
       
        public FrmVendas()
        {
            InitializeComponent();
            Venda u = new Venda();
            dtGridVenda.DataSource = u.PreencherGrid();
        }

        // Evento para o botão de adicionar nova venda
        private void btnadd_venda_Click(object sender, EventArgs e)
        {

            FrmCadastrarVendas cadastrar = new FrmCadastrarVendas();
            cadastrar.FormClosed += Fechou_Venda_FormClosed;
            cadastrar.ShowDialog();
            
        }

        // Atualiza a lista de vendas ao fechar o formulário de edição ou cadastro
        private void Fechou_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Venda u = new Venda();
            dtGridVenda.DataSource = u.PreencherGrid();
        }

        // Evento para pesquisar vendas ao digitar na caixa de texto
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Venda u = new Venda();
            dtGridVenda.DataSource = u.Pesquisar(txtpesquisa.Text);
        }

        // Evento para abrir a edição de vendas ao clicar duas vezes em uma linha
        private void dtGridVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém o ID da venda selecionada
                int id = Convert.ToInt32(
                dtGridVenda.Rows[e.RowIndex].Cells[0].Value);

                FrmEditarVendas editar = new FrmEditarVendas(id);

                // Inscreve-se no evento de fechamento do formulário de edição
               editar.FormClosed += Fechou_Venda_FormClosed;
                 
                // Abre o formulário de edição como modal
               editar.ShowDialog();
            }
        }

        private void txtpesquisa_TextChanged_1(object sender, EventArgs e)
        {
            Venda u = new Venda();
            dtGridVenda.DataSource = u.Pesquisar(txtpesquisa.Text);
        }

       
    }
}
