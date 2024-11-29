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

namespace Ecommerce.Formularios.cadastrar
{
    public partial class FrmCadastrarVendas : Form
    {
        public FrmCadastrarVendas()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            Venda p = new Venda();
            p.DataVenda = txtDataVenda.Text;
            p.Total = Convert.ToInt32(txtTotal);
            p.FormaPagamento = txtFormaPagamento.Text;
            p.Desconto = Convert.ToInt32(txtDesconto);
            p.StatusVenda = txtStatusVenda.Text;
            p.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }
    }
    }

