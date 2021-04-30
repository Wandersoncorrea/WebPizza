using System.Collections.Generic;
using WebPizza.Dominio.DAOs;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Repositorios.Interfaces;
using WebPizza.obj.Dominio.DAOs.Interfaces;

namespace WebPizza.Dominio.Repositorios.Classes
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private IEnderecoDAO enderecoDAO;
        public EnderecoRepositorio(IEnderecoDAO enderecoDAO)
        {
            this.enderecoDAO = enderecoDAO;
        }


        public void Atualizar(Endereco endereco)
        {
           this.enderecoDAO.Atualizar(endereco);
        }

        public long Cadastrar(Endereco endereco)
        {
            return this.enderecoDAO.Cadastrar(endereco);
        }

        public void Deletar(long id)
        {
            this.enderecoDAO.Deletar(id);
        }

        public Endereco Obter(long id)
        {
            return this.enderecoDAO.Obter(id);
        }

        public IEnumerable<Endereco> ObterTodos()
        {
            return this.enderecoDAO.ObterTodos();
        }
        public IEnumerable<Endereco> ObterTodos(long idCliente)
        {
            return this.enderecoDAO.ObterTodos(idCliente);
        }
    }
}