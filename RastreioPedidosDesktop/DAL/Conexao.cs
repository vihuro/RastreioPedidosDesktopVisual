using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.DAL
{
    public class Conexao
    {
        Npgsql.NpgsqlConnection con = new NpgsqlConnection();

        String conexao;

        public Conexao()
        {
            conexao = "Server = localhost; Port = 5432; Database = Pedidos_db;";
            conexao += "Username = postgres;";
            conexao += "Password = POSTGRES";
            con.ConnectionString = conexao;

        }
        public NpgsqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }

}

