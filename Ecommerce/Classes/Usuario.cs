﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ecommerce.Classes
{
    public class Usuarios
    {

        private MySqlConnection Conexao = new MySqlConnection("Server=localhost;Database=Ecommerce;User Id=root;Password=");
        
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public void Inserir()
        {
            Conexao.Open();
            string query = "Insert into Usuario (Login , Senha, Ativo) " +
                "               Values (@login, @senha, @ativo) ";
            MySqlCommand comando = new MySqlCommand(query, Conexao);

            MySqlParameter parametro1 = new MySqlParameter("@login", Login);
            MySqlParameter parametro2 = new MySqlParameter("@senha", Senha);
            MySqlParameter parametro3 = new MySqlParameter("@ativo", Ativo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable PreencherGrid()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Id, Login, Ativo FROM Usuario order by Id desc";
            Conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados para preencher grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return dataTable;
        }

        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = string.IsNullOrEmpty(pesquisa)
                ? "SELECT Id, Login, Senha, Ativo FROM Usuario ORDER BY Id DESC"
                : "SELECT Id, Login, Senha, Ativo FROM Usuario WHERE LoginLIKE '%" + pesquisa + "%' ORDER BY Id DESC";


            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados para preencher grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return dt;
            
        }

        public void Editar()
        {
            string query = "update Usuario set Login = @login, Senha = @senha, Ativo = @ativo WHERE  Id = @id";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@login", Login));
            comando.Parameters.Add(new MySqlParameter("@senha", Senha));
            comando.Parameters.Add(new MySqlParameter("@ativo", Ativo));
            comando.Parameters.Add(new MySqlParameter("@id", Id));
            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Usuário Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            string query = "Delete from Usuario WHERE  Id = @id";
            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            comando.Parameters.Add(new MySqlParameter("@id", Id));
            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Usuário Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PesquisarPorId(int id)
        {
            DataTable dataTable = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Login, Senha, Ativo Nome FROM Usuario Where Id = @id Order by Id desc";
            MySqlCommand Comando = new MySqlCommand(query, Conexao);
            Comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader resultado = Comando.ExecuteReader();

            if (resultado.Read())
            {
                Id = resultado.GetInt32(0);
                Login = resultado.GetString(1);
                Senha = resultado.GetString(2);
                Ativo = resultado.GetBoolean(3);
            }

            Conexao.Close();
        }
    }
}