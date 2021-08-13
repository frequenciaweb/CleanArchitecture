using Microsoft.EntityFrameworkCore;
using Estoque.Business.Entities;

namespace Estoque.DataAccess.EF {
   
    public class EFContext : DbContext{
           
       public DbSet<Produto> Produtos {get ;set;}
       public DbSet<Categoria> Categorias {get ;set;}
       public DbSet<Movimentacao> Movimentacoes {get ;set;}    


       protected override void OnConfiguring(DbContextOptionsBuilder builder){
          
          builder.UseSqlServer(@"Server=PCDEV\SQLEXPRESS;Database=clean_architecture;Integrated Security=true;");            

       }

    }
}