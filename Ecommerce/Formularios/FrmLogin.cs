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

namespace MapaSala
{
    public partial class frmLogin : Form
    {
        private Login login;
        public frmLogin()
        {
            InitializeComponent();
            login = new Login();
        }


        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {

        }
        // Evento ao passar o mouse sobre o botão
        private void btn_Entrar_MouseEnter(object sender, EventArgs e)
        {
            btn_Entrar.BackColor = System.Drawing.Color.LightBlue; // Escolha a cor desejada
        }

        // Evento ao tirar o mouse do botão
        private void btn_Entrar_MouseLeave(object sender, EventArgs e)
        {
            btn_Entrar.BackColor = System.Drawing.Color.White; // Retorna à cor original
        }

    }
}