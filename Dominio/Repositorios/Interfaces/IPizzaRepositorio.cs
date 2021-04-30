using System.Collections.Generic;
using WebPizza.Dominio.Models;

namespace WebPizza.Dominio.Repositorios.Interfaces
{
    public interface IPizzaRepositorio
    {
         
        Pizza Obter(long id);
        long Cadastrar(Pizza pizza);
        
        IEnumerable<Pizza> ObterTodos();
        void Atualizar(Pizza pizza);
        void Deletar(long id);
        
    }
}