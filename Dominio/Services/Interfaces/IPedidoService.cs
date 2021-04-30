using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Services.Interfaces
{
    public interface IPedidoService
    {
        Pedido Obter(long id);
        IEnumerable<Pedido> ObterTodos();
        Pedido Cadastrar(Pedido pedido);
        Pedido Atualizar(Pedido pedido);
        Pedido Deletar(long id); 
    }
}