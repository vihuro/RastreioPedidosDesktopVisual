using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.DAL
{
    internal class ListViewDao
    {
        public bool tem = false;
        Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand();
        Conexao con = new Conexao();
        Database db;
        Npgsql.NpgsqlDataReader dr;

        int bdid;
        String bdnumero_Pedido;
        String bdstatus;

       


    }
}
