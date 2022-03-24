using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;

namespace ControleAcesso.Domain.Serviços
{
    public class MovimentoPesagemServico : IMovimentoPesagemServico
    {
        protected IMovimentoPesagemRepositorio _movimentoPesagemRepositorio;
        protected IPessoaRepositorio _pessoaRepositorio;
        protected IVeiculoRepositorio _veiculoRepositorio;

        public MovimentoPesagemServico(IMovimentoPesagemRepositorio movimentoPesagemRepositorio, IPessoaRepositorio pessoaRepositorio, IVeiculoRepositorio veiculoRepositorio)
        {
            _movimentoPesagemRepositorio =  movimentoPesagemRepositorio;
            _veiculoRepositorio = veiculoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;

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

        public async Task<int> CadastrarExpedicao(MovimentoPesagemDTO movimentoDTO)
        {
            int retorno = 0;

            try
            {
                var pessoa = await _pessoaRepositorio.Pesquisar(movimentoDTO.PessoaId);
                var veiculo = await _veiculoRepositorio.Pesquisar(movimentoDTO.VeiculoId);

                if ((pessoa != null) && (veiculo != null))
                {
                    MovimentoPesagem movimento = new(movimentoDTO.PesoChegada,ETipoMovimentoPesagem.EXPEDICAO,ESentido.ENTRADA, movimentoDTO.Data, veiculo, pessoa);
                    retorno = await _movimentoPesagemRepositorio.Cadastrar(movimento);
                }

                return retorno;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> CadastrarRecebimento(MovimentoPesagemDTO movimentoDTO)
        {
            int retorno = 0;

            try
            {
                var pessoa = await _pessoaRepositorio.Pesquisar(movimentoDTO.PessoaId);
                var veiculo = await _veiculoRepositorio.Pesquisar(movimentoDTO.VeiculoId);

                if ((pessoa != null) && (veiculo != null))
                {
                    MovimentoPesagem movimento = new(movimentoDTO.PesoChegada, ETipoMovimentoPesagem.RECEBIMENTO, ESentido.ENTRADA, movimentoDTO.Data, veiculo, pessoa);
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
