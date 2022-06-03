using RastreioPedidosDesktop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RastreioPedidosDesktop.DAL
{


    internal class ListViewDao
    {
        String Result;

        Conexao con = new Conexao();
        Npgsql.NpgsqlCommand postgreSql = new Npgsql.NpgsqlCommand();
        Npgsql.NpgsqlDataReader lerDados;

        public String carregar (String numeroPedido, String dataHoraGeracao, String UsuarioGeracao)
        {
            postgreSql.CommandText = "select * from tab_Pedidos order by numero_Pedido asc";

            con.conectar();
            postgreSql.Connection = con.conectar();

            lerDados = postgreSql.ExecuteReader();

            try
            {

                while (lerDados.Read())
                {
                    numeroPedido = lerDados["numero_pedido"].ToString();
                    dataHoraGeracao = lerDados["dataHoraGeracao"].ToString();
                    UsuarioGeracao = lerDados["UsuarioGeracao"].ToString();

                }

                con.desconectar();
                postgreSql.Connection.Close();


            }
            catch (Npgsql.NpgsqlException)
            {

            }
            con.desconectar();
            postgreSql.Connection.Close();


            return Result;
        }
    }
}
