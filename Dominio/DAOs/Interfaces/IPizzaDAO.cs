using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.DAOs.Interfaces
{
    public interface IPizzaDAO
    {
        long Cadastrar(Pizza pizza);
        Pizza Obter(long id);
        IEnumerable<Pizza> ObterTodos();
        void Deletar(long id);
        void Atualizar(Pizza pizza);         
    }
}