using System;
using System.Collections.Generic;
using System.Linq;
using WebPizza.Dominio.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Models.Interfaces;

namespace WebPizza.Dominio.Models.Classes
{
    public class ItemPedido: IItemPedido
    {
      public ItemPedido(int IdItem ,bool TipoItem, string Observacao, int Quantidade, double Valor)
        {
            this.IdItem = IdItem;
            this.TipoItem  = TipoItem;
            this.Observacao = Observacao;
            this.Quantidade = Quantidade;
            this.Valor = Valor;
        }
      
        public long Id { get; set; }
        public long IdPedido { get; set; }
        public long IdItem { get; set; }
        public bool TipoItem { get; set; }
        public string Observacao { get; set; }
        public int Quantidade { get; set; }
        public double Desconto{get;set;}
        public double Valor { get; set; }
        

        public double CalcularTotal() =>
            (this.Quantidade * this.Valor);

    }

}