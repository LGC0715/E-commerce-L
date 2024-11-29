using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecommerce.Classes;

namespace Ecommerce.Formularios.editar
{
    public partial class FrmEditarVendas : Form
    {
        public FrmEditarVendas()
        {
            InitializeComponent();
        }

        private void FrmEditarVendas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Venda p = new Venda();
            p.Id = Convert.ToInt32(txtId.Text);
            p.Excluir();
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Venda p = new Venda();
            p.DataVenda = txtDataVenda.Text;
            p.Total = Convert.ToInt32(txtTotal);
            p.FormaPagamento = Convert.ToInt32(txtFormaPagamento);
            p.Desconto = Convert.ToInt32(txtDesconto); 
            p.StatusVenda = Convert.ToInt32(txtStatusVenda);
            p.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }
    }
}
