using System.Threading.Tasks;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckListController : ControllerBase
    {
        private readonly ICheckListRepositorio _rep;

        public CheckListController(ICheckListRepositorio rep)
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
        public async Task<IActionResult> Create(CheckList checklist)
        {
            var retorno = await _rep.Create(checklist);
            return Ok(retorno);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CheckList checklist)
        {
            return Ok(await _rep.Update(checklist));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            return Ok(await _rep.Delete(id));
        }
        
    }
}