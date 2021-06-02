using Locacao.Domain.Entities;

namespace Locacao
{
    public class RetiradaVeiculo : Entity
    {
        public int IdCheckListRetirada { get; set; }
        public int IdOperador { get; set; }
        public int IdAluguel { get; set; }
        
    }
}