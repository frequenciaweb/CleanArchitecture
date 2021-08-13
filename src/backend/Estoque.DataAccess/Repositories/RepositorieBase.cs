using Estoque.DataAccess.EF;
using System;
using Estoque.Business.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Estoque.DataAccess.Repositories{

 public class RepositorieBase<TEntity> : IRepositorieBase<TEntity> where TEntity : class
    {
        private readonly EFContext context;

        public RepositorieBase(EFContext context)
        {
            this.context = context;
        }

        public virtual TEntity Alterar(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            return entity;
        }

        public virtual void Excluir(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public virtual TEntity Incluir(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);            
            return entity;
        }

        public virtual TEntity Obter(Guid id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public virtual List<TEntity> Obter()
        {
            return context.Set<TEntity>().ToList();
        }
    }

}