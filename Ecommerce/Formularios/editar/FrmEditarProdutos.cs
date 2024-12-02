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
        public FrmEditarProdutos(int id)
        {
            
            InitializeComponent();
            Produto p = new Produto();
            p.PesquisarPorId(id);
            txtId.Text = p.Id.ToString();
            txtNome.Text = p.Nome;
            txtDescricao.Text = p.Descricao;
            txtPreco.Text = p.PrecoUnitario.ToString();
            txtEstoque.Text = p.Estoque.ToString();
            p = null;
        }
            

        private void FrmEditarProdutos_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Id = Convert.ToInt32(txtId.Text);
            p.Nome = txtNome.Text;
            p.Descricao = txtDescricao.Text;
            p.PrecoUnitario = Convert.ToDecimal(txtPreco.Text);
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Editar();
            p = null;
            this.Close();
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
