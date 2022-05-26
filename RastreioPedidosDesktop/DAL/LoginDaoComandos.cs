using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.DAL
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem ="";
        Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand();
        Conexao con = new Conexao();
        Npgsql.NpgsqlDataReader dr;

        public bool verificar(String login, String senha) 
        {

            cmd.CommandText = "Select * from tab_usuarios_empresa where nome = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (Npgsql.NpgsqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }

            return tem;
        }
        public String cadastrar(String nome, String senha) {

            return mensagem;

        }

    }
}
