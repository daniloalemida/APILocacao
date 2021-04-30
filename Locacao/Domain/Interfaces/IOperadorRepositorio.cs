using System.Threading.Tasks;
using Locacao.Domain.Entities.Usuarios;

namespace Locacao.Domain.Interfaces
{
    public interface IOperadorRepositorio :  IEntityRepositorio<Operador>
    {
        Task<Operador> GetByMatricula(string registro);
    }
}