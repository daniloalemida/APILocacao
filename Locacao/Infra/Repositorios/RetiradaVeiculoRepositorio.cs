using Locacao.Domain.Interfaces;
using Locacao.Infra.Database;

namespace Locacao.Infra.Repositorios
{
    public class RetiradaVeiculoRepositorio : EntityRepositorio<RetiradaVeiculo>, IRetiradaVeiculoRepositorio
    {
        public RetiradaVeiculoRepositorio(EntityContext context) : base(context)
        {
        }
    }
}