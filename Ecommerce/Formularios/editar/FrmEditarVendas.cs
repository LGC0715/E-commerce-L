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
using Ecommerce.Classes;
using MySqlConnector;

namespace Ecommerce.Formularios.editar
{
    public partial class FrmEditarVendas : Form
    {
        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=ECOMMERCE;User Id=root;Password=");
        public FrmEditarVendas(int id)
        {
            InitializeComponent();

            string query = "select Id, DataVenda, Total, FormaPagamento, Desconto. StatusVenda " +
                "from Venda where Id = @id";


            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            //comando.Parameters.Add(new SqlParameter("@id", Id));

            MySqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {

                    txtDataVenda.Text = Leitura[0].ToString();
                    txtTotal.Text = Leitura[1].ToString();
                    cbxformapag.Text = Leitura[2].ToString();
                    txtDesconto.Text = Leitura[3].ToString();
                    txtStatusVenda.Text = Leitura[4].ToString();


                };

            }

            Conexao.Close();
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
            p.FormaPagamento = cbxformapag.Text;
            p.Desconto = Convert.ToInt32(txtDesconto); 
            p.StatusVenda = txtStatusVenda.Text;
            p.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }

        private void txtStatusVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFormaPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataVenda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
