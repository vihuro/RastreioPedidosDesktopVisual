using RastreioPedidosDesktop.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastreioPedidosDesktop.Modelo
{
    internal class PedidoController
    {
        public bool have;
        public String mensagem;
        public String save;

        public bool verificarSeTemPedido(String numeroPedido)
        {
            novoPedidoDao novoPedido = new novoPedidoDao();
            have = novoPedido.verificar(numeroPedido);
            if (!novoPedido.mensagem.Equals(""))
            {
                this.mensagem = novoPedido.mensagem;
                
            }
            
            return have;
        }
        public String adicionarPedido(String numeroPedido, DateTime dataHoraGeracao, String usuario)
        {
            novoPedidoDao novoPedido = new novoPedidoDao();
            mensagem = novoPedido.cadastrar(numeroPedido, dataHoraGeracao, usuario);

            return save;
        }
    }
}
