using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.DAL
{
    internal class updatePedidoDao
    {
        public String save = "";
        public String Result;
        Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand();
        Conexao con = new Conexao();
        Npgsql.NpgsqlDataReader dataReader;


        public String cadastrar(String numeroPedido,String status,DateTime? dataEntrega,DateTime? dataFinProd, DateTime? dataIniProd, DateTime? dataPrevisaEntrega, DateTime? dataSepara, DateTime? dataTransito, String dataEntregaUsuario, String dataFinProdUsuario, String dataGeracaoUsuario, DateTime? dataHoraGeracao, String dataIniProdUsuario, String dataSeparaUsuario, String dataTransitoUsuario)
        {
            cmd.CommandText = "Update tab_Pedidos set status = @status,data_entrega= @data_entrega, data_fin_prod= @data_fin_prod, data_geracao =@data_geracao, data_ini_prod = @data_ini_prod, data_prevista_entrega = @data_prevista_entrega, data_separa = @data_separa, data_transito = @data_transito, data_entrega_usuario = @data_entrega_usuario, data_fin_prod_usuario = @data_fin_prod_usuario,data_geracao_usuario = @data_geracao_usuario, data_ini_prod_usuario = @data_ini_prod_usuario,data_separa_usuario = @data_separa_usuario,data_transito_usuario = @data_transito_usuario where numero_pedido = @numeroPedido";
            //id =?, status =?, data_entrega =?, data_prevista_entrega =?, data_separa =?, data_transito =?, numero_pedido =?, data_entrega_usuario =?, data_fin_prod_usuario =?, data_geracao_usuario =?, data_ini_prod_usuario =?, data_separa_usuario =?, data_transito_usuario =?
            cmd.Parameters.AddWithValue("@numeroPedido", numeroPedido);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@data_entrega", dataEntrega);
            cmd.Parameters.AddWithValue("@data_fin_prod", dataFinProd);
            cmd.Parameters.AddWithValue("@data_geracao", dataHoraGeracao);
            cmd.Parameters.AddWithValue("@data_ini_prod", dataIniProd);
            cmd.Parameters.AddWithValue("@data_prevista_entrega", dataPrevisaEntrega);
            cmd.Parameters.AddWithValue("@data_separa", dataSepara);
            cmd.Parameters.AddWithValue("@data_transito", dataTransito);
            cmd.Parameters.AddWithValue("@data_entrega_usuario", dataEntregaUsuario);
            cmd.Parameters.AddWithValue("@data_fin_prod_usuario", dataFinProdUsuario);
            cmd.Parameters.AddWithValue("@data_geracao_usuario", dataGeracaoUsuario);
            cmd.Parameters.AddWithValue("@data_ini_prod_usuario", dataIniProdUsuario);
            cmd.Parameters.AddWithValue("@data_separa_usuario", dataSeparaUsuario);
            cmd.Parameters.AddWithValue("@data_transito_usuario", dataTransitoUsuario);


            try
            {
                con.conectar();
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

            }
            catch(Npgsql.NpgsqlException)
            {
                this.save = "Erro com banco de Dados";
            }
            return save;
        }
    }
}
