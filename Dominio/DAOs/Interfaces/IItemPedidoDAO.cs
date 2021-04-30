using System;
using System.Collections.Generic;
using System.Linq;
using WebPizza.Dominio.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Models.Interfaces;
using WebPizza.Dominio.Models.Classes;

namespace WebPizza.Dominio.DAOs.Interfaces
{
    public interface IItemPedidoDAO
    {
        
        long Cadastrar(IEnumerable<ItemPedido> itenspedido);
        IEnumerable<ItemPedido> ObterTodos(long idPedido);
        //IEnumerable<ItemPedido> ObterTodos();        
        void Deletar(long id);
        void Atualizar(ItemPedido pedido);
    }
}