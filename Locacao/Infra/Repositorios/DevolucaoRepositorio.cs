using Locacao.Domain.Interfaces;
using Locacao.Infra.Database;

namespace Locacao.Infra.Repositorios
{
    public class DevolucaoRepositorio : EntityRepositorio<DevolucaoVeiculo>, IDevolucaoRepositorio
    {
        public DevolucaoRepositorio(EntityContext context) : base(context)
        {
        }
    }
}