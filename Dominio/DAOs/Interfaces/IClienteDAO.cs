using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.DAOs.Interfaces
{
    public interface IClienteDAO
    {
        long Cadastrar(Cliente cliente);
        Cliente Obter(long id);
        IEnumerable<Cliente> ObterTodos();
        void Deletar(long id);
        void Atualizar(Cliente cliente);
         
    }
}