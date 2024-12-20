﻿using Ecommerce.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce.Formularios.cadastrar
{
    public partial class FrmCadastrarProdutos : Form
    {
        public FrmCadastrarProdutos()
        {
            InitializeComponent();
        }

        private void FrmCadastrarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNome.Text;
            p.Descricao = txtDescricao.Text;
            p.PrecoUnitario = Convert.ToDecimal(txtPreco.Text);
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
