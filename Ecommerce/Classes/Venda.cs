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

        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Total { get; set; }
        public string FormaPagamento { get; set; } 
        public decimal Desconto { get; set; } 
        public string StatusVenda { get; set; } 




        


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
        public void Editar()
        {
            Conexao.Open();
            string query = "UPDATE Venda SET DataVenda = @datavenda, Total = @total, FormaPagamento = @formapagamento, Desconto = @desconto, StatusVenda = @StausVenda WHERE Id = @id";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", Id));
            comando.Parameters.Add(new MySqlParameter("@datavenda", DataVenda));
            comando.Parameters.Add(new MySqlParameter("@total", Total));
            comando.Parameters.Add(new MySqlParameter("@formapagamento", FormaPagamento));
            comando.Parameters.Add(new MySqlParameter("@desconto", Desconto));
            comando.Parameters.Add(new MySqlParameter("@statusvenda", StatusVenda));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Venda Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
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
                ? "SELECT Id, DataVenda, Total, FormaPagamento, Desconto, StatusVenda FROM Venda ORDER BY Id DESC"
                : "SELECT Id, DataVenda, Total, FormaPagamento, Desconto, StatusVenda FROM Venda WHERE (DataVenda LIKE '%" + pesquisa + "%') OR (Id = "+pesquisa+") ORDER BY Id DESC";


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
        public void PesquisarPorId(int id)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, DataVenda, Total, FormaPagamento, Desconto, StatusVenda  FROM Venda Where Id = @id Order by Id desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            Comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader resultado = Comando.ExecuteReader();

            if (resultado.Read())
            {
                Id = resultado.GetInt32(0); 
                DataVenda = resultado.GetDateTime(1);
                Total = resultado.GetDecimal(2); // Tipo decimal (ou float, dependendo da precisão desejada)
                FormaPagamento = resultado.GetString(3); // Tipo string (assumindo que é um texto, como "Cartão", "Dinheiro", etc.)
                Desconto = resultado.GetDecimal(4); // Tipo decimal (ou float, dependendo da precisão desejada)
                StatusVenda = resultado.GetString(5); // Tipo bool

            }

            Conexao.Close();
            
    }
    }
    }