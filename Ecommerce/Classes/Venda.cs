using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Entidade
{
    public class Venda
    {
       

        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public float Total { get; set; }
        public string FormaPagamento { get; set; } // Forma de pagamento
        public float Desconto { get; set; } // Desconto aplicado
        public string StatusVenda { get; set; } // Status da venda (Ex.: Concluída, Pendente, Cancelada)


        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=AULA_DS;User Id=root;Password=");




        public void Inserir(Venda venda)
            {
                Conexao.Open();
                string query = "INSERT INTO Vendas (DataVenda, Total, ClienteId, FormaPagamento, Desconto, StatusVenda) " +
                               "VALUES (@dataVenda, @total, @clienteId, @formaPagamento, @desconto, @statusVenda)";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@dataVenda", venda.DataVenda));
                comando.Parameters.Add(new SqlParameter("@total", venda.Total));
                comando.Parameters.Add(new SqlParameter("@formaPagamento", venda.FormaPagamento));
                comando.Parameters.Add(new SqlParameter("@desconto", venda.Desconto));
                comando.Parameters.Add(new SqlParameter("@statusVenda", venda.StatusVenda));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }

            public DataTable ObterVendas()
            {
                DataTable dt = new DataTable();
                Conexao.Open();
                string query = "SELECT Id, DataVenda, Total, ClienteId, FormaPagamento, Desconto, StatusVenda FROM Vendas ORDER BY Id DESC";
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
                        Venda venda = new Venda
                        {
                            Id = Convert.ToInt32(leitura["Id"]),
                            DataVenda = Convert.ToDateTime(leitura["DataVenda"]),
                            Total = float.Parse(leitura["Total"].ToString()),
                            FormaPagamento = leitura["FormaPagamento"].ToString(),
                            Desconto = float.Parse(leitura["Desconto"].ToString()),
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
            string query = "SELECT Id, Login, Ativo FROM Usuarios order by Id desc";
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
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT Id, Login, Ativo Nome FROM Usuarios order by Id desc";
            }
            else
            {
                query = "SELECT Id, Login, Ativo Nome FROM Usuarios Where Login like '%" + pesquisa + "%' Order by Id desc";
            }

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
        public void Atualizar(Venda venda)
            {
                Conexao.Open();
                string query = "UPDATE Vendas SET DataVenda = @dataVenda, Total = @total, ClienteId = @clienteId, " +
                               "FormaPagamento = @formaPagamento, Desconto = @desconto, StatusVenda = @statusVenda WHERE Id = @id";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", venda.Id));
                comando.Parameters.Add(new MySqlParameter("@dataVenda", venda.DataVenda));
                comando.Parameters.Add(new MySqlParameter("@total", venda.Total));
                comando.Parameters.Add(new MySqlParameter("@formaPagamento", venda.FormaPagamento));
                comando.Parameters.Add(new MySqlParameter("@desconto", venda.Desconto));
                comando.Parameters.Add(new MySqlParameter("@statusVenda", venda.StatusVenda));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }

            public void Deletar(int id)
            {
                Conexao.Open();
                string query = "DELETE FROM Vendas WHERE Id = @id";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                comando.Parameters.Add(new MySqlParameter("@id", id));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }
        }
    }