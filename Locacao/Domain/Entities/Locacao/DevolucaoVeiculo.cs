using Locacao.Domain.Entities;

namespace Locacao
{
    public class DevolucaoVeiculo : Entity
    {
        public double SubTotal { get; set; }
        public double ValorTotalPagar { get; set; }
        public double ValorAdicional {get; set; }
        public int IdCheckListDevolucao { get; set; }
        public int IdOperador { get; set; }
        public int IdAluguel { get; set; }        
    }
}