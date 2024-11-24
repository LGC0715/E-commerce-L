using System;
using System.Windows.Forms;
using Ecommerce.Entidade;
using Ecommerce.Entidade.DAO;
using Ecommerce.Entidade.Ecommerce.Entidade.DAO;

namespace Ecommerce.Formularios.cadastrar
{
    public partial class FrmCadastrarVendas : Form
    {
        private VendaDAO vendaDAO = new VendaDAO();

        public FrmCadastrarVendas()
        {
            InitializeComponent();
        }

        private void FrmCadastrarVendas_Load(object sender, EventArgs e)
        {
            // Opcional: inicializar campos ou carregar dados relacionados, se necessário.
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criação de um objeto Venda com os valores preenchidos no formulário
                Venda venda = new Venda()
                {
                     // Converte o texto para DateTime
                    Total = float.Parse(txtTotal.Text),            // Converte o texto para float
                    FormaPagamento = txtFormaPagamento.Text,       // Coleta o método de pagamento
                    Desconto = float.Parse(txtDesconto.Text),      // Coleta o desconto como float
                };

                // Salva a venda usando o DAO
                vendaDAO.Inserir(venda);

                // Exibe mensagem de sucesso
                MessageBox.Show("Venda cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos(); // Limpa os campos para nova entrada
                this.Close();   // Fecha o formulário
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro ao converter os valores. Verifique os dados inseridos:\n" + ex.Message,
                                "Erro de Formatação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar a venda:\n" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            // Limpa todos os campos de texto do formulário
           
            txtTotal.Text = "";
            txtFormaPagamento.Text = "";
            txtDesconto.Text = "";
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
