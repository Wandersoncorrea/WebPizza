using System.Collections.Generic;
using WebPizza.Dominio.DAOs;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Repositorios.Interfaces;
using WebPizza.obj.Dominio.DAOs.Interfaces;


namespace WebPizza.Dominio.Repositorios.Classes
{
    public class PizzaRepositorio : IPizzaRepositorio
    {
         private IPizzaDAO pizzaDAO;
        public PizzaRepositorio(IPizzaDAO pizzaDAO)
        {
            this.pizzaDAO = pizzaDAO;
        }
        public void Atualizar(Pizza pizza)
        {
            this.pizzaDAO.Atualizar(pizza);
        }

        public long Cadastrar(Pizza pizza)
        {
            return this.pizzaDAO.Cadastrar(pizza);
        }

        public void Deletar(long id)
        {
            this.pizzaDAO.Deletar(id);
        }

        public Pizza Obter(long id)
        {
            return this.pizzaDAO.Obter(id);
        }

        public IEnumerable<Pizza> ObterTodos()
        {
            return this.pizzaDAO.ObterTodos();
        }
    }
}