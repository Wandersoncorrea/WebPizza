using System;
using System.Collections.Generic;
using System.Linq;
using WebPizza.Dominio;
using WebPizza.Dominio.Interfaces;
using WebPizza.Dominio.Models.Interfaces;

namespace WebPizza.Dominio.Models
{
    public class Pedido : IPedido
    {
        
        //Pedido: descricao, numero, 
        //Lista de Pizzas, Lista de bebidas, 
        //desconto, frete, valor total do pedido.
        public long Id {get; set;}
        public Cliente Cliente { get; set; }
        public long Numero{get;set;}
        public string Descricao{get;set;}//????
        public List<IItemPedido> ItemPedidos  { get; set; }
        public double Desconto { get; set; } 
        public double Frete { get; set; } 
        public double ValorToTal { get; private set;}
        public DateTime DataCadastro {get;set;}
        
        public Pedido()
        {
            this.ItemPedidos = new List<IItemPedido>();
        }
        public bool ValidoParaCadastro()
        {
            return (this.ItemPedidos.Any() && this.Cliente.Id != 0);
        }

        // public void CalcularValorTotal()
        // {
        //     double valorTotalProdutos = 0;
        //     double valorTotalImpostos = 0;

        //     this.Pizzas.ForEach(produto => {
        //         valorTotalProdutos += produto.CalcularValor();
        //     });

        //     this.ValorToTal = (valorTotalProdutos + 
        //                              this.Frete - 
        //                              this.Desconto) + valorTotalImpostos;

        // }
        
        public double CalcularTotal()
        {
            throw new NotImplementedException();
        }
    }

}