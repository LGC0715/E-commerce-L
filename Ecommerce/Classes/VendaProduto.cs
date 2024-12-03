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
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;

        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");

        public void Inserir()
        {
            try
            {
                Conexao.Open();

                // Verifica se já existe um registro com a mesma chave primária
                string queryVerificar = "SELECT COUNT(*) FROM VendaProduto WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
                MySqlCommand comandoVerificar = new MySqlCommand(queryVerificar, Conexao);
                comandoVerificar.Parameters.AddWithValue("@vendaId", VendaId);
                comandoVerificar.Parameters.AddWithValue("@produtoId", ProdutoId);

                int existe = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                if (existe > 0)
                {
                    // Atualiza o registro existente
                    string queryAtualizar = "UPDATE VendaProduto SET Quantidade = Quantidade + @quantidade, PrecoUnitario = @precoUnitario WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
                    MySqlCommand comandoAtualizar = new MySqlCommand(queryAtualizar, Conexao);
                    comandoAtualizar.Parameters.AddWithValue("@vendaId", VendaId);
                    comandoAtualizar.Parameters.AddWithValue("@produtoId", ProdutoId);
                    comandoAtualizar.Parameters.AddWithValue("@quantidade", Quantidade);
                    comandoAtualizar.Parameters.AddWithValue("@precoUnitario", PrecoUnitario);
                    comandoAtualizar.ExecuteNonQuery();
                }
                else
                {
                    // Insere um novo registro
                    string queryInserir = "INSERT INTO VendaProduto (VendaId, ProdutoId, Quantidade, PrecoUnitario) VALUES (@vendaId, @produtoId, @quantidade, @precoUnitario)";
                    MySqlCommand comandoInserir = new MySqlCommand(queryInserir, Conexao);
                    comandoInserir.Parameters.AddWithValue("@vendaId", VendaId);
                    comandoInserir.Parameters.AddWithValue("@produtoId", ProdutoId);
                    comandoInserir.Parameters.AddWithValue("@quantidade", Quantidade);
                    comandoInserir.Parameters.AddWithValue("@precoUnitario", PrecoUnitario);
                    comandoInserir.ExecuteNonQuery();
                }

                MessageBox.Show("Operação realizada com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro");
            }
            finally
            {
                Conexao.Close();
            }
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
