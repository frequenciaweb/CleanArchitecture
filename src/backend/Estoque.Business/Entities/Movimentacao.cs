using System;
using Estoque.Business.Enuns;

namespace Estoque.Business.Entities {
  
   public class Movimentacao {

       public Guid ID {get; set;} 
       public DateTime Operacao {get; set;}
       public int Quantidade {get; set;}
       public EnumTipoMovimentacao Tipo {get; set;} 

       public Guid ProdutoID {get; set;}
       public Produto Produto {get; set;}

   }
}