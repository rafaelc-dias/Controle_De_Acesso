using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;

namespace ControleAcesso.Domain.Serviços
{
    public class SaidaCarroEmpresaServico : ISaidaCarroEmpresaServico
    {
        protected ISaidaCarroEmpresaRepositorio _saidaCarroEmpresaRepositorio;
        protected IPessoaRepositorio _pessoaRepositorio;
        protected IVeiculoRepositorio _veiculoRepositorio;

        public SaidaCarroEmpresaServico(ISaidaCarroEmpresaRepositorio saidaCarroEmpresaRepositorio, IPessoaRepositorio pessoaRepositorio, IVeiculoRepositorio veiculoRepositorio)
        {
            _saidaCarroEmpresaRepositorio = saidaCarroEmpresaRepositorio;
            _veiculoRepositorio = veiculoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
        }


        public async Task AlterarStatusFechado(Guid movimentoId)
        {
            try
            {
                await _saidaCarroEmpresaRepositorio.AlterarStatusFechado(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Cadastrar(SaidaCarroEmpresaSaidaDTO movimentoDTO)
        {
            int retorno = 0;

            try
            {
                var pessoa = await _pessoaRepositorio.Pesquisar(movimentoDTO.PessoaId);
                var veiculo = await _veiculoRepositorio.Pesquisar(movimentoDTO.VeiculoId);

                if ((pessoa != null) && (veiculo != null))
                {
                    SaidaCarroEmpresa movimento = new(movimentoDTO.KmSaida, movimentoDTO.NivelCombustivelSaida, movimentoDTO.HoraSaida, movimentoDTO.Destino,movimentoDTO.Data, veiculo, pessoa);
                    retorno = await _saidaCarroEmpresaRepositorio.Cadastrar(movimento);
                }

                return retorno;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(Guid movimentoId)
        {
            try
            {
                await _saidaCarroEmpresaRepositorio.Excluir(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task InserirEntrada(SaidaCarroEmpresaEntradaDTO movimento)
        {
            try
            {
                await _saidaCarroEmpresaRepositorio.InserirEntrada(movimento.Id, movimento.KmEntrada, movimento.NivelCombustivelEntrada, movimento.HoraEntrada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<SaidaCarroEmpresa>> Listar()
        {
            try
            {
                return await _saidaCarroEmpresaRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<SaidaCarroEmpresa> Pesquisar(Guid movimentoId)
        {
            try
            {
                return await _saidaCarroEmpresaRepositorio.Pesquisar(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
