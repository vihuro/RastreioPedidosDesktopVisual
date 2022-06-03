using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.Modelo
{
    internal class ListViewLoadController
    {
        String Result;

        public String LoadView(String numeroPedido, String dataHoraGeracao, String usuarioGeracao)
        {
            ListViewLoadController listController = new ListViewLoadController();

            Result = listController.LoadView(numeroPedido,dataHoraGeracao, usuarioGeracao);



            return Result;
        }
    }
}
