using Ecommerce.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Classes
{
    public class Venda
    {
       

        public int Id { get; set; }
        public string DataVenda { get; set; }
        public decimal Total { get; set; }
        public string FormaPagamento { get; set; } 
        public decimal Desconto { get; set; } 
        public string StatusVenda { get; set; } 




        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");


        public void Inserir()
            {
                Conexao.Open();
                string query = "INSERT INTO Venda (DataVenda, Total, FormaPagamento, Desconto, StatusVenda) " +
                               "VALUES (@dataVenda, @total, @formapagamento, @desconto, @statusVenda)";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                

            
            MySqlParameter parametro1 = new MySqlParameter("@datavenda", DataVenda);
            MySqlParameter parametro2 = new MySqlParameter("@total", Total);
            MySqlParameter parametro3 = new MySqlParameter("@formapagamento", FormaPagamento);
            MySqlParameter parametro4 = new MySqlParameter("@desconto", Desconto);
            MySqlParameter parametro5 = new MySqlParameter("@statusvenda", StatusVenda);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

            public DataTable ObterVendas()
            {
                DataTable dt = new DataTable();
                Conexao.Open();
                string query = "SELECT Id, DataVenda, Total, FormaPagamento, Desconto, StatusVenda FROM Venda ORDER BY Id DESC";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                MySqlDataReader leitura = comando.ExecuteReader();

                foreach (var propriedade in typeof(Venda).GetProperties())
                {
                    dt.Columns.Add(propriedade.Name);
                }

                if (leitura.HasRows)
                {
                    while (leitura.Read())
                    {
                        Venda v = new Venda
                        {
                            Id = Convert.ToInt32(leitura["Id"]),
                            DataVenda = leitura["DataVenda"].ToString(),
                            Total = decimal.Parse(leitura["Total"].ToString()),
                            FormaPagamento = leitura["FormaPagamento"].ToString(),
                            Desconto = decimal.Parse(leitura["Desconto"].ToString()),
                            StatusVenda = leitura["StatusVenda"].ToString()
                        };
                       
                    }
                }

                Conexao.Close();
                return dt;
            }
        public DataTable PreencherGrid()
        {
            DataTable dataTable = new DataTable();
            

        string query = "SELECT Id, DataVenda, Total, FormaPagamento, Desconto, StatusVenda FROM Venda order by Id desc";
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
                ? "SELECT Id, DataVenda, Descricao, Total, FormaPagamento, Desconto, StatusVenda  FROM Venda ORDER BY Id DESC"
                : "SELECT Id, DataVenda, Descricao, Total, FormaPagamento, Desconto, StatusVenda FROM Venda WHERE Nome LIKE @pesquisa ORDER BY Id DESC";

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
        public void Atualizar(Venda venda)
            {
                Conexao.Open();
                string query = "UPDATE Vendas SET DataVenda = @dataVenda, Total = @total, ClienteId = @clienteId, " +
                               "FormaPagamento = @formaPagamento, Desconto = @desconto, StatusVenda = @statusVenda WHERE Id = @id";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                comando.Parameters.Add(new MySqlParameter("@id", venda.Id));
                comando.Parameters.Add(new MySqlParameter("@dataVenda", venda.DataVenda));
                comando.Parameters.Add(new MySqlParameter("@total", venda.Total));
                comando.Parameters.Add(new MySqlParameter("@formaPagamento", venda.FormaPagamento));
                comando.Parameters.Add(new MySqlParameter("@desconto", venda.Desconto));
                comando.Parameters.Add(new MySqlParameter("@statusVenda", venda.StatusVenda));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }


        public void Excluir()
        {
            string query = "DELETE FROM Venda WHERE Id = @id";
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