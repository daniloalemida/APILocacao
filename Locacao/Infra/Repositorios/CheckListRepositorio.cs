using Locacao.Domain.Interfaces;
using Locacao.Infra.Database;

namespace Locacao.Infra.Repositorios
{
    public class CheckListRepositorio : EntityRepositorio<CheckList>, ICheckListRepositorio
    {
        public CheckListRepositorio(EntityContext context) : base(context)
        {
        }
        
    }
}