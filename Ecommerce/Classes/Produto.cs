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

        public object[] Linha()
        {
            return new object[] { Id, Nome, Descricao, PrecoUnitario, Estoque };
        }
    }

    namespace DAO
    {
        public class ProdutoDAO
        {
            private readonly string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
            private readonly SqlConnection Conexao;

            public ProdutoDAO()
            {
                Conexao = new SqlConnection(LinhaConexao);
            }

            public void Inserir(Produto produto)
            {
                Conexao.Open();
                string query = "INSERT INTO Produtos (Nome, Descricao, Preco, Estoque) VALUES (@nome, @descricao, @preco, @estoque)";
                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@nome", produto.Nome));
                comando.Parameters.Add(new SqlParameter("@descricao", produto.Descricao));
                comando.Parameters.Add(new SqlParameter("@preco", produto.PrecoUnitario));
                comando.Parameters.Add(new SqlParameter("@estoque", produto.Estoque));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }

            public DataTable ObterProdutos()
            {
                DataTable dt = new DataTable();
                Conexao.Open();
                string query = "SELECT Id, Nome, Descricao, Preco, Estoque FROM Produtos ORDER BY Id DESC";
                SqlCommand comando = new SqlCommand(query, Conexao);
                SqlDataReader leitura = comando.ExecuteReader();

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

                SqlCommand comando = new SqlCommand(query, Conexao);
                if (!string.IsNullOrEmpty(pesquisa))
                    comando.Parameters.Add(new SqlParameter("@pesquisa", "%" + pesquisa + "%"));

                SqlDataReader leitura = comando.ExecuteReader();

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
                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", produto.Id));
                comando.Parameters.Add(new SqlParameter("@nome", produto.Nome));
                comando.Parameters.Add(new SqlParameter("@descricao", produto.Descricao));
                comando.Parameters.Add(new SqlParameter("@preco", produto.PrecoUnitario));
                comando.Parameters.Add(new SqlParameter("@estoque", produto.Estoque));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }

            public void Deletar(int id)
            {
                Conexao.Open();
                string query = "DELETE FROM Produtos WHERE Id = @id";
                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", id));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }
        }
    }
}
