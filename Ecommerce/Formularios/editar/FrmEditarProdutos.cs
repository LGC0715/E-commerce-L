using Ecommerce.Classes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Formularios.editar
{
    public partial class FrmEditarProdutos : Form
    {
        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");
        public FrmEditarProdutos(int Id)
        {
            InitializeComponent();

            string query = "select Id, Nome, Descricao, PrecoUnitrio, Estoque " +
                "from Produto where Id = @id";

            
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@id", Id));

            MySqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                  
                    txtNome.Text = Leitura[0].ToString();
                    txtDescricao.Text = Leitura[1].ToString();
                    txtPreco.Text= Leitura[2].ToString();
                    txtEstoque.Text = Leitura[3].ToString();


                };

            }
            
            Conexao.Close();

        }
            

        private void FrmEditarProdutos_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNome.Text;
            p.Descricao = txtDescricao.Text;
            p.PrecoUnitario = Convert.ToInt32(txtPreco);
            p.Estoque = Convert.ToInt32(txtEstoque);
            p.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Id = Convert.ToInt32(txtId.Text);
            p.Excluir();
            this.Close();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
