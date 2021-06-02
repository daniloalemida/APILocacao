using System.Threading.Tasks;

namespace Locacao.Domain.Interfaces
{
    public interface ILoginService
    {
        Task<object> Login(string login, string senha);
         
    }
}