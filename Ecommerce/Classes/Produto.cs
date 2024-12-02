using MySqlConnector;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ecommerce.Classes
{
    public class Produto
    {
        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Estoque { get; set; }


 
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
        
        public void Editar()
        {
            Conexao.Open();
            string query = "UPDATE Produto SET Nome = @nome, Descricao = @descricao, PrecoUnitario = @preco, Estoque = @estoque WHERE Id = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", Id));
            comando.Parameters.Add(new MySqlParameter("@nome", Nome));
            comando.Parameters.Add(new MySqlParameter("@descricao", Descricao));
            comando.Parameters.Add(new MySqlParameter("@preco", PrecoUnitario));
            comando.Parameters.Add(new MySqlParameter("@estoque", Estoque));
            int resposta = comando.ExecuteNonQuery();
            
            if (resposta == 1)
            {
                MessageBox.Show("Usuário Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show("Produto Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void PesquisarPorId(int id)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Descricao, PrecoUnitario, Estoque  FROM Produto Where Id = @id Order by Id desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            Comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader resultado = Comando.ExecuteReader();

            if (resultado.Read())
            {
                Id = resultado.GetInt32(0);
                Nome = resultado.GetString(1);
                Descricao = resultado.GetString(2);
                PrecoUnitario = resultado.GetDecimal(3);
                Estoque = resultado.GetInt32(4);
            }

            Conexao.Close();
            
    }

    }
}
   