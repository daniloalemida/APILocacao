using System.Threading.Tasks;
using Locacao.Domain.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/Locacao")]
    public class AluguelController : ControllerBase
    {
        private readonly AluguelServico _aluguelService;
        public AluguelController(AluguelServico aluguelService)
        {
            this._aluguelService = aluguelService;
        }

        [HttpGet, Route("reservasCliente/{cpf}")]
        public IActionResult BuscarReservasPorCliente(string cpf)
        {
            return Ok(_aluguelService.BuscarResrvasPorCpfCliente(cpf));
        }

        [HttpPost]
        public async Task<IActionResult> CriarReserva(Aluguel aluguel)
        {
            return Ok(await _aluguelService.CriarReserva(aluguel));
        }
        
        [HttpPost, Route("RetiradaVeidulo")]
        public async Task<IActionResult> RetiradaVeiculo(int reserva, int checklist, int idOperador)
        {
            return Ok(await _aluguelService.Retirada(reserva, checklist, idOperador));
        }
        
        [HttpPost, Route("DevolucaoVeiculo")]
        public async Task<IActionResult> DevolucaoVeiculo(int reserva, int checklist, int idOperador)
        {
            return Ok(await _aluguelService.Devolucao(reserva, checklist, idOperador));
        }
        
    }
}