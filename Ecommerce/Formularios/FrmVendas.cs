using System;
using System.Data;
using System.Windows.Forms;
using Ecommerce.Entidade;
using Ecommerce.Formularios.cadastrar;
using Ecommerce.Formularios.editar;

namespace Ecommerce.Formularios
{
    public partial class FrmVendas : Form
    {
        DataTable dados;
        Venda dao = new Venda();

        public FrmVendas()
        {
            InitializeComponent();
            dados = new DataTable();

            // Adiciona colunas ao DataTable com base nas propriedades da classe Venda
            foreach (var atributos in typeof(Venda).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            // Obtém os dados das vendas e exibe na grade
           // dados = dao.ObterVendas();
            dtGridVenda.DataSource = dados;
        }

        // Evento para o botão de adicionar nova venda
        private void btnadd_venda_Click(object sender, EventArgs e)
        {

            FrmCadastrarVendas cadastrar = new FrmCadastrarVendas();

            // Inscreve-se no evento de fechamento do formulário
            cadastrar.FormClosed += Fechou_Venda_FormClosed;

            // Abre o formulário de cadastro como modal
            cadastrar.ShowDialog();
        }

        // Atualiza a lista de vendas ao fechar o formulário de edição ou cadastro
        private void Fechou_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            // dados = dao.ObterVendas();
            dtGridVenda.DataSource = dados;
        }

        // Evento para pesquisar vendas ao digitar na caixa de texto
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Pesquisar pelo texto fornecido
         //   dtGridVenda.DataSource = dao.Pesquisar(null, null); // Altere aqui se for pesquisar por datas
        }

        // Evento para abrir a edição de vendas ao clicar duas vezes em uma linha
        private void dtGridVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém o ID da venda selecionada
                int id = Convert.ToInt32(
                    dtGridVenda.Rows[e.RowIndex].Cells[0].Value);

                FrmEditarVendas editar = new FrmEditarVendas();

                // Inscreve-se no evento de fechamento do formulário de edição
               editar.FormClosed += Fechou_Venda_FormClosed;

                // Abre o formulário de edição como modal
               editar.ShowDialog();
            }
        }

        
        
    }
}
