using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Services.Interfaces
{
    public interface IPizzaService
    {
        Pizza Obter(long id);
        IEnumerable<Pizza> ObterTodos();
        Pizza Cadastrar(Pizza pizza);
        Pizza Atualizar(Pizza pizza);
        Pizza Deletar(long id);
    }
}