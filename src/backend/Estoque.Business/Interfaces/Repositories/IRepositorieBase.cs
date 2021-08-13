using System.Collections.Generic;
using System;


namespace Estoque.Business.Interfaces.Repositories {
   
     public interface IRepositorieBase<TEntity> where TEntity : class
    {
        TEntity Incluir(TEntity entity);
        TEntity Alterar(TEntity entity);
        void Excluir(TEntity entity);
        TEntity Obter(Guid id);
        List<TEntity> Obter();
    }    

}