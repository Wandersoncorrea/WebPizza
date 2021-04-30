using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Repositorios.Interfaces
{
    public interface IPedidoRepositorio
    {
         Pedido Obter(long id);
        long Cadastrar(Pedido pedido);
        
        IEnumerable<Pedido> ObterTodos();
        void Atualizar(Pedido pedido);
        void Deletar(long id);
    }
}