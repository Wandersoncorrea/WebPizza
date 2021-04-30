using System.Data.SqlClient;
//using Dapper;
using WebPizza.Dominio.Models;
using System.Linq;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.obj.Dominio.DAOs.Interfaces;
using System.Collections.Generic;

namespace WebPizza.Dominio.DAOs
{
    public class PedidoDAO : IPedidoDAO
    {
        private string connectionString;

        

        public PedidoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Atualizar(Pedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public long Cadastrar(Pedido pedido)
        {
            /*
             cadastao pedido e depois os intens
              pedido com o id do pedido
                id_pedido => Item do pedido no banco
            */
            throw new System.NotImplementedException();
        }

        public void Deletar(long id)
        {
            throw new System.NotImplementedException();
        }

        public Pedido Obter(long id)
        {
            throw new System.NotImplementedException();
        }
         public IEnumerable<Pedido> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}