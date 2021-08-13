
using Estoque.Business.Entities;
using Estoque.Business.Interfaces.Repositories;
using Estoque.DataAccess.EF;

namespace Estoque.DataAccess.Repositories{

    public class RepositorieProduto : RepositorieBase<Produto>, IRepositorieProduto
    {
        public RepositorieProduto(EFContext context) : base(context)
        {
        }
    }
}