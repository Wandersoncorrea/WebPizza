using System.Collections.Generic;
using WebPizza.Dominio.DAOs;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Repositorios.Interfaces;
using WebPizza.obj.Dominio.DAOs.Interfaces;

namespace WebPizza.Dominio.Repositorios.Classes
{
    public class BebidaRepositorio : IBebidaRepositorio
    {
        private IBebidaDAO bebidaDAO;
        public BebidaRepositorio(IBebidaDAO bebidaDAO)
        {
            this.bebidaDAO = bebidaDAO;
        }
        public void Atualizar(Bebida bebida)
        {
            this.bebidaDAO.Atualizar(bebida);
        }

        public long Cadastrar(Bebida bebida)
        {
           return this.bebidaDAO.Cadastrar(bebida);
        }

        public void Deletar(long id)
        {
            this.bebidaDAO.Deletar(id);
        }

        public Bebida Obter(long id)
        {
           return this.Obter(id);
        }

        public IEnumerable<Bebida> ObterTodos()
        {
            return this.bebidaDAO.ObterTodos();
        }
    }
}