using System.Collections.Generic;
using WebPizza.Dominio.DAOs;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Repositorios.Interfaces;
using WebPizza.obj.Dominio.DAOs.Interfaces;

namespace WebPizza.Dominio.Repositorios
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        private IPedidoDAO pedidoDAO;
        public PedidoRepositorio(IPedidoDAO pedidoDAO)
        {
            this.pedidoDAO = pedidoDAO;
        }

        public void Atualizar(Pedido pedido)
        {
            this.pedidoDAO.Atualizar(pedido); 
        }

        public long Cadastrar(Pedido pedido)
        {
           return this.pedidoDAO.Cadastrar(pedido);
        }

        public void Deletar(long id)
        {
            this.pedidoDAO.Deletar(id);
        }

        public Pedido Obter(long id)
        {
            return this.pedidoDAO.Obter(id);
        }

        public IEnumerable<Pedido> ObterTodos()
        {
            return this.pedidoDAO.ObterTodos();
        }
    }
}
