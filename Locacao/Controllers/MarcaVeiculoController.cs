using System.Threading.Tasks;
using Locacao.Domain.Entities.Veiculo;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaVeiculoController : ControllerBase
    {
        private readonly IMarcaVeiculoRepositorio _rep;

        public MarcaVeiculoController(IMarcaVeiculoRepositorio rep)
        {
            _rep = rep;
        }
        
        [HttpGet]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> GetAll(){
            
            return Ok(await _rep.GetAll());
        }

        [HttpGet("{id}")]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _rep.GetById(id));
        }

        [HttpPost]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Create(MarcaVeiculo marca)
        {
            var retorno = await _rep.Create(marca);
            return Ok(retorno);
        }

        [HttpPut]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Update(MarcaVeiculo marca)
        {
            return Ok(await _rep.Update(marca));
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Delete(int id){
            return Ok(await _rep.Delete(id));
        }        
    }
}