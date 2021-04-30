using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Services.Interfaces
{
    public interface IClienteService
    {
        Cliente Obter(long id);
        IEnumerable<Cliente> ObterTodos();
        Cliente Cadastrar(Cliente cliente);
        Cliente Atualizar(Cliente cliente);
        Cliente Deletar(long id);

    }
}