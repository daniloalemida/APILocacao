using Locacao.Domain.Entities;

namespace Locacao
{
    public class RetiradaVeiculo : Entity
    {
        public CheckList CheckListDevolucao { get; set; }
        public int IdOperario { get; set; }
        public int IdAluguel { get; set; }
        
    }
}