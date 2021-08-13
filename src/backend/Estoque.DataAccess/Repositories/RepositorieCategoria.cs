
using Estoque.Business.Entities;
using Estoque.Business.Interfaces.Repositories;
using Estoque.DataAccess.EF;

namespace Estoque.DataAccess.Repositories{

    public class RepositorieCategoria : RepositorieBase<Categoria>, IRepositorieCategoria
    {
        public RepositorieCategoria(EFContext context):base(context)
        {
        }
    }
}