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
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Login = txtLogin.Text;
            u.Senha = txtSenha.Text;
         
            u.Inserir();
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
