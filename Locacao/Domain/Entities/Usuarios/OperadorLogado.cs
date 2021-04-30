using Locacao.Domain.Enums;

namespace Locacao.Domain.Entities.Usuarios
{
    public class OperadorLogado
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public TipoUsuario? Role { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Token { get; set; } 
    }
}