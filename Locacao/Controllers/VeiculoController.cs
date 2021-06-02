using System.Threading.Tasks;
using Locacao.Domain.Entities.Veiculo;
using Locacao.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController :ControllerBase    
    {
        private readonly IVeiculoRepositorio _rep;

        public VeiculoController(IVeiculoRepositorio rep)
        {
            _rep = rep;
        }

        [HttpGet]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> GetAll()
        {
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
        public async Task<IActionResult> Create(Veiculo veiculo)
        {
            var car = await _rep.GetByPlaca(veiculo.Placa);

            try
            {
                if (car == null)
            {
                var veiculoCad = new Veiculo
                {
                    Placa = veiculo.Placa,
                    ValorDiaria = veiculo.ValorDiaria,
                    CapacidadeTanqueCombustivel = veiculo.CapacidadeTanqueCombustivel,
                    CapacidadePortaMalas = veiculo.CapacidadePortaMalas,
                    IdMarca = veiculo.IdMarca,
                    IdModelo = veiculo.IdModelo,
                    Ano = veiculo.Ano,
                    FotoVeiculo = veiculo.FotoVeiculo,
                    IdAgencia = veiculo.IdAgencia,
                    CarroDisponivel = true
                };

                return Ok(await _rep.Create(veiculo));
            }
            else{
                return Ok("Veiculo já cadastrado!");
            }
                
            }
            catch (System.Exception ex)
            {
                return Ok(ex.Message);                
                
            }

            
        }

        [HttpPut]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Update(Veiculo modelo)
        {
            return Ok(await _rep.Update(modelo));
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Operator")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _rep.Delete(id));
        }        
    }
}