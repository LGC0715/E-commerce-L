using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.Classes
{
    public class Login
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool Logar()
        {
            string query = "Select Login, Id from usuarios where Senha = @senha AND Login = @login";
            Conexao.Open();
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@senha", Senha));
            comando.Parameters.Add(new SqlParameter("@login", Usuario));
            SqlDataReader resultado = comando.ExecuteReader();

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