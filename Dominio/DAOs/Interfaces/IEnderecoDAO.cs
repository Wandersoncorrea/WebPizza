using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.DAOs.Interfaces
{
    public interface IEnderecoDAO
    {
        long Cadastrar(Endereco endereco);
        Endereco Obter(long id);
        IEnumerable<Endereco> ObterTodos();
        IEnumerable<Endereco> ObterTodos(long idCliente);
        void Deletar(long id);
        void Atualizar(Endereco endereco);
         
    }
}