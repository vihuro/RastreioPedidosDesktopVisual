using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastreioPedidosDesktop.Service
{
    public class loadPedidosListViewApontamento
    {
        String listandoItems;

        public void loadApontamento()
        {

            String[] listPedidos = new String[5];
            listPedidos[0] = "Data/Hora Geração";
            listPedidos[1] = "Data/Hora Ini. Prod";
            listPedidos[2] = "Data/Hora Fin. Prod";
            listPedidos[3] = "Data/Hora Separação";
            listPedidos[4] = "Data/Hora Transito";

            ListViewItem listitem = new ListViewItem(listPedidos);
            frmPedidos frmPedido = new frmPedidos();

            frmPedido.listViewApontamento.Items.Add(listitem);

            

        }
    }
}
