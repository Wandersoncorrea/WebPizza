using System;
using System.Collections.Generic;
using System.Linq;
using WebPizza.Dominio.Interfaces;
using WebPizza.Dominio.Models;
using WebPizza.Dominio.Models.Interfaces;

namespace WebPizza.Dominio.Models
{
public class Bebida : IBebida
{

    //Bebida: descricao, tamanho,  valor
    public long Id {get; set;}
    public string Descricao{get;set;}
    public string Tamanho{get;set;}
    public double Valor{get;set;}
    public DateTime DataCadastro {get;set;}

         public bool ValidoParaCadastro()
        {
         return (this.Valor != 0 && 
                    !String.IsNullOrWhiteSpace(this.Descricao) &&
                    !String.IsNullOrWhiteSpace(this.Tamanho));
        }

       
    }

}