using System.Data.SqlClient;
using Dapper;
using WebPizza.Dominio.Models;
using System.Linq;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.obj.Dominio.DAOs.Interfaces;
using System.Collections.Generic;
using WebPizza.Dominio.Models.Classes;

namespace WebPizza.Dominio.DAOs.Classes
{
    public class ItemPedidoDAO : IItemPedidoDAO
    {
        private string connectionString;

        public ItemPedidoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Atualizar(ItemPedido pedido)
        {
            throw new System.NotImplementedException();
        }

        public long Cadastrar(IEnumerable<ItemPedido> itenspedido)
        {
             string sql="insert into intens_pedido(id_item,id_pedido,tipo,obsevacao,quantidade,desconto)values(@IdPedido,IdItem,TipoItem,Observacao,Quantidade,Desconto)";
            
             using(var conexao = new SqlConnection(this.connectionString))
                 {
                     conexao.Open();
                     return conexao.Execute(sql , itenspedido);

                 }
          
          
        }

        public void Deletar(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ItemPedido> ObterTodos(long idPedido)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<ItemPedido> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}