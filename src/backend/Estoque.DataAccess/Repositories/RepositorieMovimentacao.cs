using Estoque.Business.Entities;
using Estoque.Business.Interfaces.Repositories;
using Estoque.DataAccess.EF;

namespace Estoque.DataAccess.Repositories{

    public class RepositorieMovimentacao : RepositorieBase<Movimentacao>, IRepositorieMovimentacao
    {
        public RepositorieMovimentacao(EFContext context) : base(context)
        {
        }
    }
}