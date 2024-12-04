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
        public decimal Subtotal
        {
            get { return Quantidade * PrecoUnitario; }
        }

        public void Inserir()
        {
            try
            {
                // Abrir a conexão com o banco de dados
                Conexao.Open();

                // Verificar se o registro já existe
                string query = "SELECT COUNT(*) FROM VendaProduto WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                comando.Parameters.Add(new MySqlParameter("@vendaId", VendaId));
                comando.Parameters.Add(new MySqlParameter("@produtoId", ProdutoId));

                int count = Convert.ToInt32(comando.ExecuteScalar());

                if (count > 0)
                {
                    // Registro já existe, atualizar quantidade e subtotal
                    string queryUpdate = "UPDATE VendaProduto " +
                                         "SET Quantidade = Quantidade + @quantidade, " +
                                         "Subtotal = Subtotal + @novoSubtotal " +
                                         "WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
                    MySqlCommand comandoUpdate = new MySqlCommand(queryUpdate, Conexao);
                    comandoUpdate.Parameters.Add(new MySqlParameter("@quantidade", Quantidade));
                    comandoUpdate.Parameters.Add(new MySqlParameter("@novoSubtotal", Quantidade * PrecoUnitario));
                    comandoUpdate.Parameters.Add(new MySqlParameter("@vendaId", VendaId));
                    comandoUpdate.Parameters.Add(new MySqlParameter("@produtoId", ProdutoId));

                    comandoUpdate.ExecuteNonQuery();
                }
                else
                {
                    // Registro não existe, inserir novo
                    string queryInsert = "INSERT INTO VendaProduto (VendaId, ProdutoId, PrecoUnitario, Quantidade, Subtotal) " +
                                         "VALUES (@vendaId, @produtoId, @precoUnitario, @quantidade, @subtotal)";
                    MySqlCommand comandoInsert = new MySqlCommand(queryInsert, Conexao);
                    comandoInsert.Parameters.Add(new MySqlParameter("@vendaId", VendaId));
                    comandoInsert.Parameters.Add(new MySqlParameter("@produtoId", ProdutoId));
                    comandoInsert.Parameters.Add(new MySqlParameter("@precoUnitario", PrecoUnitario));
                    comandoInsert.Parameters.Add(new MySqlParameter("@quantidade", Quantidade));
                    comandoInsert.Parameters.Add(new MySqlParameter("@subtotal", Quantidade * PrecoUnitario));

                    comandoInsert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Tratar exceção para evitar travamentos
                throw new Exception("Erro ao inserir ou atualizar o registro: " + ex.Message, ex);
            }
            finally
            {
                // Garantir o fechamento da conexão
                if (Conexao.State == System.Data.ConnectionState.Open)
                    Conexao.Close();
            }
             
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
                MessageBox.Show("Venda excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
