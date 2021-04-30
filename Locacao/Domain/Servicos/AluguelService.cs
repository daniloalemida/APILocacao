using System.Collections.Generic;
using System.Threading.Tasks;
using Locacao.Domain.Interfaces;

namespace Locacao.Domain.Servicos
{
    public class AluguelService : IAluguelService
    {
        public List<Aluguel> BuscarResrvasPorCpfCliente(string cpf)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> CriarReserva(Aluguel reserva)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Devolucao(Aluguel reserva, CheckList checklist)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Retirada(Aluguel reserva, CheckList checklist)
        {
            throw new System.NotImplementedException();
        }
    }
}