using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecommerce;
using Ecommerce.Classes;

namespace Ecommerce.Formularios
{
    public partial class frmLoginncs : Form
    {
        private Login login;
        public frmLoginncs()
        {
            InitializeComponent();
            login = new Login();
        }
        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            login.Usuario = txtLogin.Text;
            login.Senha = txtSenha.Text;
            if (login.Logar())
            {
                FrmPrincipal p = new FrmPrincipal();
                p.FormClosed += FecharForm;
                this.Hide();
                p.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoginncs_Load(object sender, EventArgs e)
        {

        }
    }
}
