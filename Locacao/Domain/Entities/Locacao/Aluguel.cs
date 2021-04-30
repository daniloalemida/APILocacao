using System;
using Locacao.Domain.Entities;
using Locacao.Domain.Entities.Usuarios;
using Locacao.Domain.Entities.Veiculo;

namespace Locacao
{
    public class Aluguel : Entity
    {
        public Veiculo Veiculo { get; set; }
        public Double TotalDiariasLocacao { get; set; }
        public Double ValorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataRetirada { get; set; }
        public int IdAgenciaRetirada {get; set;}
        public Agencia LocalDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int IdRetirada { get; set; } // fazer entity retirada
        public int IdDevolucao {get; set;}        
        public bool LocacaoAtiva { get; set; }
        public int IdDevolucaoVeiculo { get; set; }
 
    }
}