using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Cliente Obter(long id);
        long Cadastrar(Cliente cliente);
       
        IEnumerable<Cliente> ObterTodos();
        void Atualizar(Cliente cliente);
        void Deletar(long id);
        
         
    }
}