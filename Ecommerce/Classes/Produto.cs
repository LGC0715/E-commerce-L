using MySqlConnector;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ecommerce.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Estoque { get; set; }


        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");
        public void Inserir()
        {
            Conexao.Open();
            string query = "INSERT INTO Produto (Nome, Descricao, PrecoUnitario, Estoque) VALUES (@nome, @descricao, @preco, @estoque)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            MySqlParameter parametro1 = new MySqlParameter("@nome", Nome);
            MySqlParameter parametro2 = new MySqlParameter("@descricao", Descricao);
            MySqlParameter parametro3 = new MySqlParameter("@preco", PrecoUnitario);
            MySqlParameter parametro4 = new MySqlParameter("@estoque", Estoque);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PreencherGrid()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Id, Nome, Descricao, PrecoUnitario, Estoque FROM Produto ORDER BY Id DESC";
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
        public DataTable ObterProdutos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Descricao, PrecoUnitario, Estoque FROM Produto ORDER BY Id DESC";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataReader leitura = comando.ExecuteReader();

            foreach (var propriedade in typeof(Produto).GetProperties())
            {
                dt.Columns.Add(propriedade.Name);
            }

            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    Produto p = new Produto
                    {
                        Id = Convert.ToInt32(leitura["Id"]),
                        Nome = leitura["Nome"].ToString(),
                        Descricao = leitura["Descricao"].ToString(),
                        PrecoUnitario = decimal.Parse(leitura["PrecoUnitario"].ToString()),
                        Estoque = Convert.ToInt32(leitura["Estoque"])
                    };
                }
            }

            Conexao.Close();
            return dt;
        }
       
        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = string.IsNullOrEmpty(pesquisa)
                ? "SELECT Id, Nome, Descricao, PrecoUnitario, Estoque FROM Produto ORDER BY Id DESC"
                : "SELECT Id, Nome, Descricao, PrecoUnitario, Estoque FROM Produto WHERE Nome LIKE @pesquisa ORDER BY Id DESC";

            MySqlCommand comando = new MySqlCommand(query, Conexao);
            if (!string.IsNullOrEmpty(pesquisa))
                comando.Parameters.Add(new MySqlParameter("@pesquisa", "%" + pesquisa + "%"));

            MySqlDataReader leitura = comando.ExecuteReader();

            foreach (var propriedade in typeof(Produto).GetProperties())
            {
                dt.Columns.Add(propriedade.Name);
            }

            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    Produto p = new Produto
                    {
                        Id = Convert.ToInt32(leitura["Id"]),
                        Nome = leitura["Nome"].ToString(),
                        Descricao = leitura["Descricao"].ToString(),
                        PrecoUnitario = decimal.Parse(leitura["PrecoUnitario"].ToString()),
                        Estoque = Convert.ToInt32(leitura["Estoque"])
                    };
                   
                }
            }

            Conexao.Close();
            return dt;
        }

        public void Atualizar(Produto produto)
        {
            Conexao.Open();
            string query = "UPDATE Produto SET Nome = @nome, Descricao = @descricao, PrecoUnitario = @preco, Estoque = @estoque WHERE Id = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", produto.Id));
            comando.Parameters.Add(new MySqlParameter("@nome", produto.Nome));
            comando.Parameters.Add(new MySqlParameter("@descricao", produto.Descricao));
            comando.Parameters.Add(new MySqlParameter("@preco", produto.PrecoUnitario));
            comando.Parameters.Add(new MySqlParameter("@estoque", produto.Estoque));
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public void Excluir()
        {
            string query = "DELETE FROM Produto WHERE Id = @id";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", Id));
            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Usuário Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
   