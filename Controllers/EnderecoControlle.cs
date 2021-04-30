using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPizza.Dominio.Models;
using WebPizza;
using Microsoft.AspNetCore.Mvc;
using WebPizza.Dominio.Services.Interfaces;

namespace WebPizza.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]

    public class EnderecoControlle : ControllerBase
    {
        private readonly IEnderecoService _servicoEndereco;

        // public PedidoController(IPedidoService pedidoService) => this._servicoPedido = pedidoService;
        public EnderecoControlle(IEnderecoService enderecoService)
        {
            this._servicoEndereco = enderecoService;
        }
    }
}