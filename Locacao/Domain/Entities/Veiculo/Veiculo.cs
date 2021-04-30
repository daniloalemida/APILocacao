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
        public MarcaVeiculo Marca {get; set;}
        public ModeloVeiculo Modelo {get;set;}
        public int Ano { get; set; }
        public CategoriaVeiculo Categoria { get; set; }
        public TipoCombustivel Combustivel {get; set;}
        public string FotoVeiculo {get; set;}
        public bool CarroDisponivel { get; set; }
        public int IdAgencia { get; set; }
    }
}