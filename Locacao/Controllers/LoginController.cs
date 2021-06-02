using System.Threading.Tasks;
using Locacao.Domain.Entities.Usuarios;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _log;
        public LoginController(ILoginService log)
        {
            _log = log;
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var result = await _log.Login(usuario.Login, usuario.Senha);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return Ok("Erro no Login");
            }
        }        
    }
}