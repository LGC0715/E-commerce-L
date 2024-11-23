using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entidade
{
    public class Venda
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");

        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public float Total { get; set; }
        public string FormaPagamento { get; set; } // Forma de pagamento
        public float Desconto { get; set; } // Desconto aplicado
        public string StatusVenda { get; set; } // Status da venda (Ex.: Concluída, Pendente, Cancelada)

        public object[] Linha()
        {
            return new object[] { Id, DataVenda, Total, FormaPagamento, Desconto, StatusVenda };
        }
    }

    namespace Ecommerce.Entidade.DAO
    {
        public class VendaDAO
        {
            private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
            private SqlConnection Conexao;

            public VendaDAO()
            {
                Conexao = new SqlConnection(LinhaConexao);
            }

            public void Inserir(Venda venda)
            {
                Conexao.Open();
                string query = "INSERT INTO Vendas (DataVenda, Total, ClienteId, FormaPagamento, Desconto, StatusVenda) " +
                               "VALUES (@dataVenda, @total, @clienteId, @formaPagamento, @desconto, @statusVenda)";
                SqlCommand comando = new SqlCommand(query, Conexao);
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
                SqlCommand comando = new SqlCommand(query, Conexao);
                SqlDataReader leitura = comando.ExecuteReader();

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
                        dt.Rows.Add(venda.Linha());
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
                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", venda.Id));
                comando.Parameters.Add(new SqlParameter("@dataVenda", venda.DataVenda));
                comando.Parameters.Add(new SqlParameter("@total", venda.Total));
                comando.Parameters.Add(new SqlParameter("@formaPagamento", venda.FormaPagamento));
                comando.Parameters.Add(new SqlParameter("@desconto", venda.Desconto));
                comando.Parameters.Add(new SqlParameter("@statusVenda", venda.StatusVenda));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }

            public void Deletar(int id)
            {
                Conexao.Open();
                string query = "DELETE FROM Vendas WHERE Id = @id";
                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", id));
                comando.ExecuteNonQuery();
                Conexao.Close();
            }
        }
    }
}