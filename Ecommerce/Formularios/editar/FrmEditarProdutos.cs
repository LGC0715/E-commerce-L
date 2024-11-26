using Ecommerce.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Formularios.editar
{
    public partial class FrmEditarProdutos : Form
    {
        public FrmEditarProdutos()
        {
            
        }

        private void FrmEditarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
    }
}
