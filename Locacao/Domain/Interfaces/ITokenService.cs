namespace Locacao.Domain.Interfaces
{
    public interface ITokenService
    {
        string GerarToken(string login, string role);  
    }
}