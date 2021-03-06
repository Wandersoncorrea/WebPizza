using System.Collections.Generic;
using WebPizza.Dominio.DAOs;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Repositorios.Interfaces;

namespace WebPizza.Dominio.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private IClienteDAO clienteDAO;
        public ClienteRepositorio(IClienteDAO clienteDAO)
        {
            this.clienteDAO = clienteDAO;
        }
        public Cliente Obter(long id)
        {
            return this.clienteDAO.Obter(id);
        }     

        public IEnumerable<Cliente> ObterTodos()
        {
            return this.ObterTodos();//new List<Cliente>();
        }

        public long Cadastrar(Cliente cliente)
        {
            return this.clienteDAO.Cadastrar(cliente);
        }

        
        public void Atualizar(Cliente cliente)
        {
            this.clienteDAO.Atualizar(cliente);
        }

        
        public void Deletar(long id)
        {
           this.clienteDAO.Deletar(id);
        }

       
    }
}
