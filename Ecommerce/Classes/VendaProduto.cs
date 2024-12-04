using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ecommerce.Classes
{
    public class VendaProduto
    {
        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=Ecommerce;User Id=root;Password=");

        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;

        public void Inserir()
        {
            Conexao.Open();
            string query = "INSERT INTO VendaProduto (VendaId, ProdutoId, PrecoUnitario, Quantidade, Subtotal) " +
                           "VALUES (@vendaId, @produtoId, @precoUnitario, @quantidade, @subtotal)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@vendaId", VendaId));
            comando.Parameters.Add(new MySqlParameter("@produtoId", ProdutoId));
            comando.Parameters.Add(new MySqlParameter("@precoUnitario", PrecoUnitario));
            comando.Parameters.Add(new MySqlParameter("@quantidade", Quantidade));
            comando.Parameters.Add(new MySqlParameter("@subtotal", Subtotal));

            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable PreencherGrid()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT VendaId, ProdutoId, PrecoUnitario, Quantidade, Subtotal FROM VendaProduto ORDER BY VendaId DESC";
            Conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados para preencher grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return dataTable;
        }

        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = string.IsNullOrEmpty(pesquisa)
                ? "SELECT VendaId, ProdutoId, PrecoUnitario, Quantidade, Subtotal FROM VendaProduto ORDER BY VendaId DESC"
                : "SELECT VendaId, ProdutoId, PrecoUnitario, Quantidade, Subtotal FROM VendaProduto WHERE ProdutoId LIKE '%" + pesquisa + "%' ORDER BY VendaId DESC";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados para preencher grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return dt;
        }

        public void Editar()
        {
            string query = "UPDATE VendaProduto SET ProdutoId = @produtoId, PrecoUnitario = @precoUnitario, Quantidade = @quantidade, Subtotal = @subtotal WHERE VendaId = @vendaId";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@produtoId", ProdutoId));
            comando.Parameters.Add(new MySqlParameter("@precoUnitario", PrecoUnitario));
            comando.Parameters.Add(new MySqlParameter("@quantidade", Quantidade));
            comando.Parameters.Add(new MySqlParameter("@subtotal", Subtotal));
            comando.Parameters.Add(new MySqlParameter("@vendaId", VendaId));

            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Venda atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
        }

        public void Excluir()
        {
            string query = "DELETE FROM VendaProduto WHERE VendaId = @vendaId";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@vendaId", VendaId));

            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Venda excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
        }

        public void PesquisarPorId(int id)
        {
            Conexao.Open();
            string query = "SELECT VendaId, ProdutoId, PrecoUnitario, Quantidade, Subtotal FROM VendaProduto WHERE VendaId = @vendaId ORDER BY VendaId DESC";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@vendaId", id));

            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.Read())
            {
                VendaId = resultado.GetInt32(0);
                ProdutoId = resultado.GetInt32(1);
                PrecoUnitario = resultado.GetDecimal(2);
                Quantidade = resultado.GetInt32(3);
            }

            Conexao.Close();
        }
    }
}
