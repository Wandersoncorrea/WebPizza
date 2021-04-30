using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.obj.Dominio.DAOs.Interfaces
{
    public interface IPedidoDAO
    {
        long Cadastrar(Pedido pedido);
        Pedido Obter(long id);
        IEnumerable<Pedido> ObterTodos();
        void Deletar(long id);
        void Atualizar(Pedido pedido);
    }
}