using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Ecommerce.Entidade
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float PrecoUnitario { get; set; }
        public int Estoque { get; set; }



        private readonly string LinhaConexao = "Server=localhost;Database=AULA_DS;User Id=root;Password=";
        private readonly MySqlConnection Conexao;



        public void Inserir(Produto produto)
        {
            Conexao.Open();
            string query = "INSERT INTO Produtos (Nome, Descricao, Preco, Estoque) VALUES (@nome, @descricao, @preco, @estoque)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@nome", produto.Nome));
            comando.Parameters.Add(new MySqlParameter("@descricao", produto.Descricao));
            comando.Parameters.Add(new MySqlParameter("@preco", produto.PrecoUnitario));
            comando.Parameters.Add(new MySqlParameter("@estoque", produto.Estoque));
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable ObterProdutos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Descricao, Preco, Estoque FROM Produtos ORDER BY Id DESC";
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
                        PrecoUnitario = float.Parse(leitura["Preco"].ToString()),
                        Estoque = Convert.ToInt32(leitura["Estoque"])
                    };
                    dt.Rows.Add(p.Linha());
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
                ? "SELECT Id, Nome, Descricao, Preco, Estoque FROM Produtos ORDER BY Id DESC"
                : "SELECT Id, Nome, Descricao, Preco, Estoque FROM Produtos WHERE Nome LIKE @pesquisa ORDER BY Id DESC";

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
                        PrecoUnitario = float.Parse(leitura["Preco"].ToString()),
                        Estoque = Convert.ToInt32(leitura["Estoque"])
                    };
                    dt.Rows.Add(p.Linha());
                }
            }

            Conexao.Close();
            return dt;
        }

        public void Atualizar(Produto produto)
        {
            Conexao.Open();
            string query = "UPDATE Produtos SET Nome = @nome, Descricao = @descricao, Preco = @preco, Estoque = @estoque WHERE Id = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", produto.Id));
            comando.Parameters.Add(new MySqlParameter("@nome", produto.Nome));
            comando.Parameters.Add(new MySqlParameter("@descricao", produto.Descricao));
            comando.Parameters.Add(new MySqlParameter("@preco", produto.PrecoUnitario));
            comando.Parameters.Add(new MySqlParameter("@estoque", produto.Estoque));
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public void Deletar(int id)
        {
            Conexao.Open();
            string query = "DELETE FROM Produtos WHERE Id = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", id));
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}
   