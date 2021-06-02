using System.Collections.Generic;
using System.Threading.Tasks;
using Locacao.Domain.Interfaces;

namespace Locacao.Domain.Servicos
{
    public class AluguelServico : IAluguelService
    { 
        private readonly IAluguelRepositorio _aluguelRepositorio;
        private readonly IDevolucaoRepositorio _devolucaoRepositorio;
        private readonly IRetiradaVeiculoRepositorio _retiradaRepositorio;
        private readonly ICheckListRepositorio _checkListRepositorio;
        private readonly IAluguelRepositorio _reserva;
        
    
        public AluguelServico(IAluguelRepositorio reserva, ICheckListRepositorio CheckListRepositorio, IAluguelRepositorio aluguelRepositorio, IDevolucaoRepositorio devolucaoRepositorio, IRetiradaVeiculoRepositorio retiradaRepositorio)
        {
            this._aluguelRepositorio = aluguelRepositorio;
            this._devolucaoRepositorio = devolucaoRepositorio;
            this._retiradaRepositorio = retiradaRepositorio;
            this._checkListRepositorio = CheckListRepositorio;
            this._reserva = reserva;
        }

        
        public List<Aluguel> BuscarResrvasPorCpfCliente(string cpf){
            return _aluguelRepositorio.BuscarResrvasPorCpfCliente(cpf);                        
        }

        public async Task<object> CriarReserva(Aluguel reserva)
        {
             if(reserva.Veiculo.CarroDisponivel){

                reserva.Veiculo.CarroDisponivel = false;
                return await _aluguelRepositorio.CreateAndReturn(reserva);
            }
            else{
                return "veiculo não disponivel";
            }   
        }

        public async Task<object> Devolucao(int idreserva, int idchecklist, int id)
        {
            var devolucao = new DevolucaoVeiculo{};
            
            var checklist = this._checkListRepositorio.GetById(idchecklist);

            var reserva = _reserva.GetById(idreserva);

            devolucao.SubTotal = reserva.Result.ValorTotal;
            devolucao.ValorTotalPagar = reserva.Result.ValorTotal;

            if(!checklist.Result.CarroLimpo) 
                devolucao.ValorAdicional += (reserva.Result.ValorTotal * (30 / 100));
            if (!checklist.Result.Arranhoes)
                devolucao.ValorAdicional += (reserva.Result.ValorTotal * (30 / 100));
            if (!checklist.Result.Amassado)
                devolucao.ValorAdicional += (reserva.Result.ValorTotal * (30 / 100));
            if (!checklist.Result.TanqueCheio)
                devolucao.ValorAdicional += (reserva.Result.ValorTotal * (30 / 100));

            devolucao.ValorTotalPagar = devolucao.SubTotal + devolucao.ValorAdicional;

            devolucao.IdCheckListDevolucao = idchecklist;
            devolucao.IdAluguel = reserva.Id;
            devolucao.IdOperador = id;                      

            var CarDevolvido = await _devolucaoRepositorio.Create(devolucao);
            
            if(CarDevolvido){
                return devolucao;
            }
            else{
                return "Erro na devolucao";
            }
        }

        public async Task<object> Retirada(int idreserva, int checklist, int idOperador)
        {
            var retirada = new  RetiradaVeiculo{};

            retirada.IdAluguel = idreserva;
            retirada.IdOperador = idOperador;
            retirada.IdCheckListRetirada = checklist;

            var CarRetirado = await _retiradaRepositorio.Create(retirada);
            
            if(CarRetirado){
                return retirada;
            }
            else{
                return "Erro na retirada";
            }
        }
    }
}