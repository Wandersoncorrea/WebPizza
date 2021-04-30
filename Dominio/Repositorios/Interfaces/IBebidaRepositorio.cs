using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Repositorios.Interfaces
{
    public interface IBebidaRepositorio
    {
        Bebida Obter(long id);
        long Cadastrar(Bebida bebida);
       
        IEnumerable<Bebida> ObterTodos();
        void Atualizar(Bebida bebida);
        void Deletar(long id);
    }
}