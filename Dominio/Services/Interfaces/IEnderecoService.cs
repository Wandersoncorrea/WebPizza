using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Services.Interfaces
{
    public interface IEnderecoService
    {
        Endereco Obter(long id);
        IEnumerable<Endereco> ObterTodos();
         IEnumerable<Endereco> ObterTodos(long idCliente);
        Endereco Cadastrar(Endereco endereco);
        Endereco Atualizar(Endereco endereco);
        Endereco Deletar(long id);
    }
}