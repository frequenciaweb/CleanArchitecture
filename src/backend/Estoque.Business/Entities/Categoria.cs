using System;
using System.Collections.Generic;

namespace Estoque.Business.Entities {

   public class Categoria {
 
     public Guid ID {get; set;}
     public string Nome {get; set;}
     public string Descricao {get; set;}

     public List<Produto> Produtos {get; set;}

   }
 
}