using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ecommerce.Classes
{
    public class VendaProduto
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public float PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public float Subtotal => Quantidade * PrecoUnitario;

        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");

        public void Inserir()
        {
            Conexao.Open();
            string query = "INSERT INTO VendaProdutos (VendaId, ProdutoId, Quantidade, PrecoUnitario) VALUES (@vendaId, @produtoId, @quantidade, @precoUnitario)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.AddWithValue("@vendaId", VendaId);
            comando.Parameters.AddWithValue("@produtoId", ProdutoId);
            comando.Parameters.AddWithValue("@quantidade", Quantidade);
            comando.Parameters.AddWithValue("@precoUnitario", PrecoUnitario);

            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        
        public DataTable PreencherGrid()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT VendaId, ProdutoId, Quantidade, PrecoUnitario, (Quantidade * PrecoUnitario) AS Subtotal FROM VendaProdutos ORDER BY VendaId DESC";
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
                ? "SELECT VendaId, ProdutoId, Quantidade, PrecoUnitario, (Quantidade * PrecoUnitario) AS Subtotal FROM VendaProdutos ORDER BY VendaId DESC"
                : "SELECT VendaId, ProdutoId, Quantidade, PrecoUnitario, (Quantidade * PrecoUnitario) AS Subtotal FROM VendaProdutos WHERE ProdutoId LIKE @pesquisa ORDER BY VendaId DESC";

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            if (!string.IsNullOrEmpty(pesquisa))
                comando.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

            MySqlDataReader leitura = comando.ExecuteReader();

            dt.Columns.Add("VendaId");
            dt.Columns.Add("ProdutoId");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("PrecoUnitario");
            dt.Columns.Add("Subtotal");

            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    DataRow row = dt.NewRow();
                    row["VendaId"] = leitura["VendaId"];
                    row["ProdutoId"] = leitura["ProdutoId"];
                    row["Quantidade"] = leitura["Quantidade"];
                    row["PrecoUnitario"] = leitura["PrecoUnitario"];
                    row["Subtotal"] = leitura["Subtotal"];
                    dt.Rows.Add(row);
                }
            }

            Conexao.Close();
            return dt;
        }

        
        public void Excluir()
        {
            string query = "DELETE FROM VendaProdutos WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.AddWithValue("@vendaId", VendaId);
            comando.Parameters.AddWithValue("@produtoId", ProdutoId);

            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("VendaProduto excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.Close();
        }
    }
}
