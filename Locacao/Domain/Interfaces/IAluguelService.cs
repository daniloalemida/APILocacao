using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Locacao.Domain.Interfaces
{
    public interface IAluguelService
    {
        List<Aluguel> BuscarResrvasPorCpfCliente(string cpf);
        
        Task<Object> CriarReserva(Aluguel reserva);

        Task<Object> Devolucao(int idreserva, int checklist, int id);

        Task<Object> Retirada(int idreserva, int checklist, int id);         
    }
}