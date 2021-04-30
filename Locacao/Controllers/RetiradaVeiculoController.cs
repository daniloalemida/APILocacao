using System.Threading.Tasks;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RetiradaVeiculoController : ControllerBase
    {
        private readonly IRetiradaVeiculoRepositorio _rep;

        public RetiradaVeiculoController(IRetiradaVeiculoRepositorio rep)
        {
            _rep = rep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            
            return Ok(await _rep.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _rep.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(RetiradaVeiculo retiradaVeiculo)
        {
            var retorno = await _rep.Create(retiradaVeiculo);
            return Ok(retorno);
        }

        [HttpPut]
        public async Task<IActionResult> Update(RetiradaVeiculo retiradaVeiculo)
        {
            return Ok(await _rep.Update(retiradaVeiculo));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            return Ok(await _rep.Delete(id));
        }
        
    }
}