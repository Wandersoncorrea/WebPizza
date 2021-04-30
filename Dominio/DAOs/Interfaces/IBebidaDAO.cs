using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.DAOs.Interfaces
{
    public interface IBebidaDAO
    {
        long Cadastrar(Bebida bebida);
        Bebida Obter(long id);
        IEnumerable<Bebida> ObterTodos();
        void Deletar(long id);
        void Atualizar(Bebida bebida);
         
    }
}