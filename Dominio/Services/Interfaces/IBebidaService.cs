using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Services.Interfaces
{
    public interface IBebidaService
    {
         Bebida Obter(long id);
        IEnumerable<Bebida> ObterTodos();
        Bebida Cadastrar(Bebida bebida);
        Bebida Atualizar(Bebida bebida);
        Bebida Deletar(long id);
    }
}