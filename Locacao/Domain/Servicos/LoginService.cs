using System.Threading.Tasks;
using Locacao.Domain.Entities.Usuarios;
using Locacao.Domain.Interfaces;

namespace Locacao.Domain.Servicos
{
    public class LoginService : ILoginService
    {
        private readonly IClienteRepositorio _cli;
        private readonly IOperadorRepositorio _ope;
        private readonly ICriptografarServico _cri;
        private readonly ITokenService _tok;

        public LoginService(IClienteRepositorio cli, IOperadorRepositorio ope, ICriptografarServico cri, ITokenService tok)
        {
            _cli = cli;
            _ope = ope;
            _cri = cri;
            _tok = tok;
        }

        public async Task<object> Login(string login, string senha)
        {
            if (login.Length == 11)
            {
                var cliente = await _cli.GetByCPF(login);

                if (cliente != null)
                {
                    if (_cri.VerifyPasswordHash(senha, cliente.PasswordHash, cliente.PasswordSalt))
                    {
                        return new ClienteLogado()
                        {
                            Id = cliente.Id,
                            Role = cliente.Role,
                            Nome = cliente.Nome,
                            CPF = cliente.CPF,
                            Data_nasc = cliente.Data_nasc,
                            CEP = cliente.CEP,
                            Logradouro = cliente.Logradouro,
                            Numero = cliente.Numero,
                            Complemento = cliente.Complemento,
                            Bairro = cliente.Bairro,
                            Cidade = cliente.Cidade,
                            UF = cliente.UF,
                            Celular = cliente.Celular,
                            Email = cliente.Email,
                            Token = _tok.GerarToken(cliente.Login, cliente.Role.ToString())
                        };

                    }
                    else
                    {
                        return "Senha invalida";
                    }
                }
                else
                {
                    return "Usuário não exite";
                }

            }
            var operador = await _ope.GetByMatricula(login);
            if (operador != null)
            {

                if (_cri.VerifyPasswordHash(senha, operador.PasswordHash, operador.PasswordSalt))
                {
                    return new OperadorLogado()
                    {
                        Id = operador.Id,
                        Role = operador.Role,
                        Nome = operador.Nome,
                        Matricula = operador.Matricula,
                        Token = _tok.GerarToken(operador.Login, operador.Role.ToString())
                    };
                }
                else
                {
                    return "Senha invalida";
                }
            }
            return "Operador não existe";
        }



        
    }
}