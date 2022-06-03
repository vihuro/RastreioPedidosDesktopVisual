using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.DAL
{
    internal class novoPedidoDao
    {
        public bool have = false;
        public String mensagem = "";
        Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand();
        Conexao con = new Conexao();
        Npgsql.NpgsqlDataReader dataReader;

        public bool verificar(String numeroPedido)
        {
            cmd.CommandText = "Select * from tab_Pedidos where numero_Pedido = @numeroPedido";
            cmd.Parameters.AddWithValue("@numeroPedido", numeroPedido);

            try
            {
                cmd.Connection = con.conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    have = true;
                }
            }
            catch(Npgsql.NpgsqlException)
            {
                this.mensagem = "Erro na conexão com o banco";
            }
            return have;
        }
        public String cadastrar(String numeroPedido, DateTime dataHoraGeracao, String usuario)
        {
            cmd.CommandText = "INSERT INTO tab_Pedidos(data_geracao, numero_pedido, data_geracao_usuario) VALUES ( @dataHoraGeracao, @numeroPedido , @usuario)";
            cmd.Parameters.AddWithValue("@numeroPedido", numeroPedido);
            cmd.Parameters.AddWithValue("@dataHoraGeracao", dataHoraGeracao);
            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                con.conectar();
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

            }
            catch(Npgsql.NpgsqlException)
            {
                this.mensagem = "Erro com banco de Dados";
            }
            return mensagem;
        }

    }
}
