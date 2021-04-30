using System.ComponentModel;

namespace Locacao.Domain.Enums
{
    public enum CategoriaVeiculo
    {
        [Description("Basico")]
        Basico = 1,
        
        [Description("Completo")]
        Completo = 2,

         [Description("Luxo")]        
        Luxo = 3 
        
    }
}