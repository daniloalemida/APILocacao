using System.Threading.Tasks;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevolucaoController : ControllerBase
    {
        private readonly IDevolucaoRepositorio _rep;

        public DevolucaoController(IDevolucaoRepositorio rep)
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
        public async Task<IActionResult> Create(DevolucaoVeiculo devolucaoVeiculo)
        {
            var retorno = await _rep.Create(devolucaoVeiculo);
            return Ok(retorno);
        }

        [HttpPut]
        public async Task<IActionResult> Update(DevolucaoVeiculo devolucaoVeiculo)
        {
            return Ok(await _rep.Update(devolucaoVeiculo));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            return Ok(await _rep.Delete(id));
        }
        
    }
}