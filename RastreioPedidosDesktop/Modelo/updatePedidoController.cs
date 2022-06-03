using RastreioPedidosDesktop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.Modelo
{
    internal class updatePedidoController
    {
        public String mensagem;
        public String save;
        
        public String UpdatePedidoController(String numeroPedido, String status, DateTime? dataEntrega, DateTime? dataFinProd, DateTime? dataIniProd, DateTime? dataPrevisaEntrega, DateTime? dataSepara, DateTime? dataTransito, String dataEntregaUsuario, String dataFinProdUsuario, String dataGeracaoUsuario, DateTime? dataHoraGeracao, String dataIniProdUsuario, String dataSeparaUsuario, String dataTransitoUsuario)
        {

            updatePedidoDao updateDao = new updatePedidoDao();
            mensagem = updateDao.cadastrar(numeroPedido, status, dataEntrega, dataFinProd, dataIniProd, dataPrevisaEntrega, dataSepara, dataTransito, dataEntregaUsuario, dataFinProdUsuario, dataGeracaoUsuario, dataHoraGeracao, dataIniProdUsuario, dataSeparaUsuario, dataTransitoUsuario);

            return save;

        }
    }
}
