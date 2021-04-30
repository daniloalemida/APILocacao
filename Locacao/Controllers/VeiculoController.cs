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
            var car = _rep.GetByPlaca(veiculo.Placa);

            if (car != null)
            {
                var veiculoCad = new Veiculo
                {
                    Placa = veiculo.Placa,
                    ValorDiaria = veiculo.ValorDiaria,
                    CapacidadeTanqueCombustivel = veiculo.CapacidadeTanqueCombustivel,
                    CapacidadePortaMalas = veiculo.CapacidadePortaMalas,
                    Marca = veiculo.Marca,
                    Modelo = veiculo.Modelo,
                    Ano = veiculo.Ano,
                    Categoria = veiculo.Categoria,
                    Combustivel = veiculo.Combustivel,
                    FotoVeiculo = veiculo.FotoVeiculo,
                    IdAgencia = veiculo.IdAgencia,
                    CarroDisponivel = true
                };

                var retorno = await _rep.Create(veiculoCad);
                return Ok(retorno);
            }
            else{
                return Ok("Veiculo já cadastrado!");
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