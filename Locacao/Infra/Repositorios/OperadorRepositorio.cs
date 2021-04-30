using System.Threading.Tasks;
using Locacao.Domain.Entities.Usuarios;
using Locacao.Domain.Interfaces;
using Locacao.Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Locacao.Infra.Repositorios
{
    public class OperadorRepositorio : EntityRepositorio<Operador>, IOperadorRepositorio
    {
        public OperadorRepositorio(EntityContext context) : base(context)
        {
        }

        public async Task<Operador> GetByMatricula(string matricula)
        {
            return await _context.Set<Operador>().FirstOrDefaultAsync(e => e.Matricula == matricula);
        }
        
    }
}