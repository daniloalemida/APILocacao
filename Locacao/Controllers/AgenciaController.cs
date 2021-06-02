using System.Threading.Tasks;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgenciaController : ControllerBase
    {
        private readonly IAgenciaRepositorio _rep;

        public AgenciaController(IAgenciaRepositorio rep)
        {
            _rep = rep;
        }

        [HttpGet]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> GetAll(){
            
            return Ok(await _rep.GetAll());
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Operator")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _rep.GetById(id));
        }

        [HttpPost]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Create(Agencia agencia)
        {
            var retorno = await _rep.Create(agencia);
            return Ok(retorno);
        }

        [HttpPut]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Update(Agencia agencia)
        {
            return Ok(await _rep.Update(agencia));
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Delete(int id){
            return Ok(await _rep.Delete(id));
        }        
    }
}