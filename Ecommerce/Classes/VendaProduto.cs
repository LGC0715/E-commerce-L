using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public class VendaProduto
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public float PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public float Subtotal => Quantidade * PrecoUnitario;

        public object[] Linha()
        {
            return new object[] { VendaId, ProdutoId, Quantidade, PrecoUnitario, Subtotal };
        }
    }
    public class VendaProdutoDAO
    {
        private string linhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection conexao;

        public VendaProdutoDAO()
        {
            conexao = new SqlConnection(linhaConexao);
        }

        /// Insere um novo registro de VendaProduto.
 
        public void Inserir(VendaProduto vendaProduto)
        {
            conexao.Open();
            string query = @"
                INSERT INTO VendaProdutos (VendaId, ProdutoId, Quantidade, PrecoUnitario) 
                VALUES (@vendaId, @produtoId, @quantidade, @precoUnitario)";
            SqlCommand comando = new SqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@vendaId", vendaProduto.VendaId);
            comando.Parameters.AddWithValue("@produtoId", vendaProduto.ProdutoId);
            comando.Parameters.AddWithValue("@quantidade", vendaProduto.Quantidade);
            comando.Parameters.AddWithValue("@precoUnitario", vendaProduto.PrecoUnitario);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

       /// Atualiza um registro existente de VendaProduto.
      
        public void Atualizar(VendaProduto vendaProduto)
        {
            conexao.Open();
            string query = @"
                UPDATE VendaProdutos 
                SET Quantidade = @quantidade, PrecoUnitario = @precoUnitario 
                WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
            SqlCommand comando = new SqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@vendaId", vendaProduto.VendaId);
            comando.Parameters.AddWithValue("@produtoId", vendaProduto.ProdutoId);
            comando.Parameters.AddWithValue("@quantidade", vendaProduto.Quantidade);
            comando.Parameters.AddWithValue("@precoUnitario", vendaProduto.PrecoUnitario);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        /// <summary>
        /// Deleta um registro específico de VendaProduto.
        /// </summary>
        public void Deletar(int vendaId, int produtoId)
        {
            conexao.Open();
            string query = "DELETE FROM VendaProdutos WHERE VendaId = @vendaId AND ProdutoId = @produtoId";
            SqlCommand comando = new SqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@vendaId", vendaId);
            comando.Parameters.AddWithValue("@produtoId", produtoId);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        /// <summary>
        /// Retorna todos os registros de VendaProdutos com detalhes de produto.
        /// </summary>
        public DataTable ObterVendaProdutos()
        {
            DataTable dt = new DataTable();
            conexao.Open();
            string query = @"
                SELECT vp.VendaId, vp.ProdutoId, p.Nome AS Produto, vp.Quantidade, vp.PrecoUnitario, 
                       (vp.Quantidade * vp.PrecoUnitario) AS Subtotal
                FROM VendaProdutos vp
                INNER JOIN Produtos p ON vp.ProdutoId = p.Id
                ORDER BY vp.VendaId";
            SqlCommand comando = new SqlCommand(query, conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dt);
            conexao.Close();
            return dt;
        }

        /// <summary>
        /// Pesquisa registros de VendaProdutos por nome do produto.
        /// </summary>
        public DataTable Pesquisar(string termo)
        {
            DataTable dt = new DataTable();
            conexao.Open();
            string query = @"
                SELECT vp.VendaId, vp.ProdutoId, p.Nome AS Produto, vp.Quantidade, vp.PrecoUnitario, 
                       (vp.Quantidade * vp.PrecoUnitario) AS Subtotal
                FROM VendaProdutos vp
                INNER JOIN Produtos p ON vp.ProdutoId = p.Id
                WHERE p.Nome LIKE @termo
                ORDER BY vp.VendaId";
            SqlCommand comando = new SqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@termo", $"%{termo}%");
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dt);
            conexao.Close();
            return dt;
        }
    }
 }
