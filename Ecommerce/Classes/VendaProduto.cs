using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ecommerce.Classes
{
    public class VendaProduto
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public float PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public float Subtotal => Quantidade * PrecoUnitario;


        private readonly string LinhaConexao = "Server=localhost;Database=AULA_DS;User Id=root;Password=";
        private readonly MySqlConnection Conexao;



        /// Insere um novo registro de VendaProduto.

        public void Inserir(VendaProduto vendaProduto)
        {
            Conexao.Open();
            string query = @"
                INSERT INTO VendaProdutos (VendaId, ProdutoId, Quantidade, PrecoUnitario) 
                VALUES (@vendaId, @produtoId, @quantidade, @precoUnitario)";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.AddWithValue("@vendaId", vendaProduto.VendaId);
            comando.Parameters.AddWithValue("@produtoId", vendaProduto.ProdutoId);
            comando.Parameters.AddWithValue("@quantidade", vendaProduto.Quantidade);
            comando.Parameters.AddWithValue("@precoUnitario", vendaProduto.PrecoUnitario);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

       /// Atualiza um registro existente de VendaProduto.
      
        public void Atualizar(VendaProduto vendaProduto)
        {
            Conexao.Open();
            string query = @"
                UPDATE VendaProdutos 
                SET Quantidade = @quantidade, PrecoUnitario = @precoUnitario 
                WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.AddWithValue("@vendaId", vendaProduto.VendaId);
            comando.Parameters.AddWithValue("@produtoId", vendaProduto.ProdutoId);
            comando.Parameters.AddWithValue("@quantidade", vendaProduto.Quantidade);
            comando.Parameters.AddWithValue("@precoUnitario", vendaProduto.PrecoUnitario);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        
        /// Deleta um registro específico de VendaProduto.
       
        public void Deletar(int vendaId, int produtoId)
        {
            Conexao.Open();
            string query = "DELETE FROM VendaProdutos WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.AddWithValue("@vendaId", vendaId);
            comando.Parameters.AddWithValue("@produtoId", produtoId);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        
        /// Retorna todos os registros de VendaProdutos com detalhes de produto.
        
        public DataTable ObterVendaProdutos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = @"
                SELECT vp.VendaId, vp.ProdutoId, p.Nome AS Produto, vp.Quantidade, vp.PrecoUnitario, 
                       (vp.Quantidade * vp.PrecoUnitario) AS Subtotal
                FROM VendaProdutos vp
                INNER JOIN Produtos p ON vp.ProdutoId = p.Id
                ORDER BY vp.VendaId";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dt);
            Conexao.Close();
            return dt;
        }

        
        /// Pesquisa registros de VendaProdutos por nome do produto.
      
        public DataTable Pesquisar(string termo)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = @"
                SELECT vp.VendaId, vp.ProdutoId, p.Nome AS Produto, vp.Quantidade, vp.PrecoUnitario, 
                       (vp.Quantidade * vp.PrecoUnitario) AS Subtotal
                FROM VendaProdutos vp
                INNER JOIN Produtos p ON vp.ProdutoId = p.Id
                WHERE p.Nome LIKE @termo
                ORDER BY vp.VendaId";
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.AddWithValue("@termo", $"%{termo}%");
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dt);
            Conexao.Close();
            return dt;
        }
    }
 }
