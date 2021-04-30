using System.ComponentModel;

namespace Locacao.Domain.Enums
{
    public enum TipoCombustivel
    {
        [Description("Alcool")]
        Alcool = 1,

        [Description("Gasolina")]
        Gasolina = 2,

        [Description("Diesel")]
        Diesel = 3,

        [Description("Flex")]
        Flex = 4
    }
}