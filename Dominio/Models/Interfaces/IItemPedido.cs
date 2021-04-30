using System;
using System.Collections.Generic;
using System.Linq;
using WebPizza.Dominio.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Models.Interfaces;

namespace WebPizza.Dominio.Models.Interfaces
{
    public interface IItemPedido
    {
        
        double CalcularTotal();

    }
}