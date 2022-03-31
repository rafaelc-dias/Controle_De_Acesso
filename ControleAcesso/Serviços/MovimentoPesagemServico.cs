using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.Serviços
{
    public class MovimentoPesagemServico : IMovimentoPesagemServico
    {
        protected IMovimentoPesagemRepositorio _movimentoPesagemRepositorio;
        protected IPessoaRepositorio _pessoaRepositorio;
        protected IVeiculoRepositorio _veiculoRepositorio;
        protected IObservacaoRepositorio _observacaoRepositorio;

        public MovimentoPesagemServico(IMovimentoPesagemRepositorio movimentoPesagemRepositorio, IPessoaRepositorio pessoaRepositorio, IVeiculoRepositorio veiculoRepositorio, IObservacaoRepositorio observacaoRepositorio)
        {
            _movimentoPesagemRepositorio = movimentoPesagemRepositorio;
            _veiculoRepositorio = veiculoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
            _observacaoRepositorio = observacaoRepositorio; 

        }

        public async Task AlterarStatusFechado(Guid movimentoId)
        {
            try
            {
                await _movimentoPesagemRepositorio.AlterarStatusFechado(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task InsereObservacao(ObservacaoMovimentoPesagemDTO observacaoDTO)
        {
            try
            {
                var _novaobservacao = observacaoDTO.ConverteObservacao();

                await _observacaoRepositorio.Cadastrar(_novaobservacao);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Cadastrar(MovimentoPesagemDTO movimentoDTO)
        {
            int retorno = 0;

            try
            {
                var pessoa = await _pessoaRepositorio.Pesquisar(movimentoDTO.PessoaId);
                var veiculo = await _veiculoRepositorio.Pesquisar(movimentoDTO.VeiculoId);



                if ((pessoa != null) && (veiculo != null))
                {
                    MovimentoPesagem movimento = new(movimentoDTO.PesoChegada, movimentoDTO.TipoMovimento, ESentido.ENTRADA, movimentoDTO.Data, veiculo, pessoa);

                    if (movimentoDTO.Observacoes != null)
                    {
                        movimentoDTO.Observacoes.ForEach(observacoes => movimento.IncluirObservacao(observacoes.ConverteObservacao()));
                    }

                    retorno = await _movimentoPesagemRepositorio.Cadastrar(movimento);
                }

                return retorno;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DefinirPesoSaida(MovimentoPesagemPesoSaidaDTO movimentoPesagemPesoSaidaDTO)
        {
            try
            {
                await _movimentoPesagemRepositorio.DefinirPesoSaida(movimentoPesagemPesoSaidaDTO.ID, movimentoPesagemPesoSaidaDTO.PesoSaida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DefinirStatusPesagem(Guid movimentoId)
        {
            try
            {
                await _movimentoPesagemRepositorio.DefinirStatusPesagem(movimentoId);
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
                await _movimentoPesagemRepositorio.Excluir(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<MovimentoPesagem>> Listar()
        {
            try
            {
                return await _movimentoPesagemRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<MovimentoPesagem> Pesquisar(Guid movimentoId)
        {
            try
            {
                return await _movimentoPesagemRepositorio.Pesquisar(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
