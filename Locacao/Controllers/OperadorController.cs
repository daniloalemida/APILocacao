using System.Threading.Tasks;
using Locacao.Domain.Entities.Usuarios;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperadorController : ControllerBase
    {
         private readonly IOperadorRepositorio _ope;
        private readonly ICriptografarServico _cri;

        public OperadorController(IOperadorRepositorio ope, ICriptografarServico cri)
        {
            _ope = ope;
            _cri = cri;
        }

         [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var operadores = await _ope.GetAll();
            return Ok(operadores);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ope.GetById(id));
        }

        [HttpGet, Route("buscarPorMatricula/{matricula}")]
        public async Task<IActionResult> GetByMatricula(string matricula)
        {
            return Ok(await _ope.GetByMatricula(matricula));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Operador operador)
        {
            var user = await _ope.GetByMatricula(operador.Matricula);
            if (user == null)
            {
                byte[] passwordHash, passwordSalt;
                _cri.CreatePasswordHash(operador.Senha, out passwordHash, out passwordSalt);
                var operadorCad = new Operador
                {
                    Login = operador.Matricula,
                    Senha = operador.Senha,
                    Role = Domain.Enums.TipoUsuario.Operador,
                    Nome = operador.Nome,
                    Matricula = operador.Matricula,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt
                };
                return Ok(await _ope.Create(operadorCad));

            }
            return Ok("Usuario já existe!");
        }

        [HttpDelete("{matricula}")]
        public async Task<ActionResult<bool>> Delete(string matricula)
        {
            var idUser = _ope.GetByMatricula(matricula).Id;
            return await _ope.Delete(idUser);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> Update(Operador operador)
        {
            return await _ope.Update(operador);
        }       
    }
}