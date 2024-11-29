
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public class Login
    {
        private MySqlConnection Conexao = new MySqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool Logar()
        {
            string query = "Select Login, Id from usuarios where Senha = @senha AND Login = @login";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@senha", Senha));
            comando.Parameters.Add(new SqlParameter("@login", Usuario));
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.HasRows)
            {
                Conexao.Close();
                return true;
            }
            else
            {
                Conexao.Close();
                return false;
            }
        }
    }
}