using System.Collections.Generic;

namespace Locacao.Domain.Interfaces
{
    public interface IAluguelRepositorio : IEntityRepositorio<Aluguel>
    {
        List<Aluguel> BuscarResrvasPorCpfCliente(string cpf);
         
    }
}