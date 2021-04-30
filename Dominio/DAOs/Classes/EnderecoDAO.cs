using System.Data.SqlClient;
using Dapper;
using WebPizza.Dominio.Models;
using System.Linq;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.obj.Dominio.DAOs.Interfaces;
using System.Collections.Generic;

namespace WebPizza.Dominio.DAOs
{
    public class EnderecoDAO : IEnderecoDAO
    {
         private string connectionString;
         public EnderecoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Atualizar(Endereco endereco)
        {
                       var sql = @"UPDATE endereco
                        SET cep = @Cep,
                            rua   = @rua,
                            numero = @Numero,
                            bairro = @Bairro,
                            cidade = @Cidade,
                            complemento  = @Complemento, 
                            pontoreferencia    = @PontoReferencia
                            
                        WHERE id = @Id";


            using(var conexao = new SqlConnection(this.connectionString))
            {
               conexao.Execute(sql, endereco);
            }
        }

        public long Cadastrar(Endereco endereco)
        {
            using(var conexao = new SqlConnection(this.connectionString))
            {
               return conexao.Query<long>(@"INSERT INTO endereco 
                                        (cep,rua,numero,bairro,cidade,complemento,pontoreferencia) 
                                      VALUES
                                      (@Cep,@Rua,@Numero,@Bairro,@Cidade,@Complemento,@Pontoreferencia,);
                                      SELECT SCOPE_IDENTITY()",
                                      endereco ).FirstOrDefault();
            }
        }

        public void Deletar(long id)
        {
              using(var conexao = new SqlConnection(this.connectionString))
            {
                conexao.Execute(@"DELETE FROM endereco  
                                WHERE id = @Id", new { @Id = id } );
            }
        }

        public Endereco Obter(long id)
        {
            using(var conexao = new SqlConnection(this.connectionString))
            {
               return conexao.Query<Endereco>(@"SELECT * FROM endereco
                                              WHERE id = @Id", new { @Id = id } ).FirstOrDefault();
            }
        }

    /// <summary>
    /// obter todos os clientes
    /// </summary>
    /// <returns></returns>
        public IEnumerable<Endereco> ObterTodos()
        {
            using(var conexao = new SqlConnection(this.connectionString))
            {
               return (IEnumerable<Endereco>)conexao.
               Query<Endereco[]>(@"SELECT * FROM endereco" ).ToList();
            }
        }
        /// <summary>
        /// obter todos os endereços de um cliente
        /// em fase de teste
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>IEnumerable<Endereco></returns>
         public IEnumerable<Endereco> ObterTodos(long idCliente)
        {
            using(var conexao = new SqlConnection(this.connectionString))
            {
               return (IEnumerable<Endereco>)conexao.
               Query<Endereco[]>(@"SELECT * FROM endereco WHERE id_cliente= @id_cliente",
                                 new { @id_cliente = idCliente }).ToList();
            }
        }
    }
    
    }