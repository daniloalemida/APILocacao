using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Locacao.Domain.Interfaces
{
    public interface IAluguelService
    {
        List<Aluguel> BuscarResrvasPorCpfCliente(string cpf);
        
        Task<Object> CriarReserva(Aluguel reserva);

        Task<Object> Devolucao(Aluguel reserva, CheckList checklist);

        Task<Object> Retirada(Aluguel reserva, CheckList checklist);         
    }
}