using System.Collections.Generic;
using System.Linq;
using Locacao.Domain.Interfaces;
using Locacao.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Locacao.Infra.Repositorios
{
    public class AluguelRepositorio : EntityRepositorio<Aluguel>, IAluguelRepositorio
    {
        public AluguelRepositorio(EntityContext context) : base(context){}

        public List<Aluguel> BuscarResrvasPorCpfCliente(string cpf)
        {
            return this._context.Aluguel
            .Include(x => x.Veiculo)
            .Include(x => x.Cliente)
            .Include(x => x.TotalDiariasLocacao)
            .Include(x => x.ValorTotal)
            .Include(x => x.DataRetirada)
            .Include(x => x.DataDevolucao)    
            .Include(x => x.LocalDevolucao)
            .Where(x => x.Cliente.CPF == cpf).ToList();
        }
    }
        
}