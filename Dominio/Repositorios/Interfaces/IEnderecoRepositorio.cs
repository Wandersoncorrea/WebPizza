using System.Collections.Generic;
using WebPizza.Dominio.Models;


namespace WebPizza.Dominio.Repositorios.Interfaces
{
    public interface IEnderecoRepositorio
    {
        Endereco Obter(long id);
        long Cadastrar(Endereco endereco);        
        IEnumerable<Endereco> ObterTodos();
        IEnumerable<Endereco> ObterTodos(long idCliente);
        void Atualizar(Endereco endereco);
        void Deletar(long id);
    }
}