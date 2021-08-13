using System;
using System.Collections.Generic;

namespace Estoque.Business.Entities {
    
    public class Produto {
       
        public Guid ID {get; set;}
        
        public string Nome {get; set;}
        public string Descricao {get; set;}      
        public decimal Preco {get ;set;}
        public int Quantidade {get; set;}

        public Categoria Categoria {get; set;}
        public Guid CategoriaID {get; set;}

        public List<Movimentacao> Movimentacoes {get; set;}

    }

  
  }