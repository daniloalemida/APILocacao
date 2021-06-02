using System;
using Locacao.Domain.Enums;

namespace Locacao.Domain.Entities.Veiculo
{
    public class Veiculo : Entity
    {
        public string Placa { get; set; }
        public Double ValorDiaria { get; set; }
        public int CapacidadeTanqueCombustivel { get; set; }
        public int CapacidadePortaMalas { get; set; }
        public int IdMarca {get; set;}
        public int IdModelo {get;set;}
        public int Ano { get; set; }
        public string FotoVeiculo {get; set;}
        public bool CarroDisponivel { get; set; }
        public int IdAgencia { get; set; }
    }
}