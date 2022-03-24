using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;

namespace ControleAcesso.Domain.Serviços
{
    public class EntradaFuncionarioServico : IEntradaFuncionarioServico
    {
        protected IEntradaFuncionarioRepositorio _entradaFuncionarioRepositorio;
        protected IPessoaRepositorio _pessoaRepositorio;
        protected IVeiculoRepositorio _veiculoRepositorio;

        public EntradaFuncionarioServico(IEntradaFuncionarioRepositorio entradaFuncionarioRepositorio, IPessoaRepositorio pessoaRepositorio, IVeiculoRepositorio veiculoRepositorio)
        {
            _entradaFuncionarioRepositorio = entradaFuncionarioRepositorio;
            _veiculoRepositorio = veiculoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
        }

        public async Task AlterarStatusFechado(Guid movimentoId)
        {
            try
            {
                await _entradaFuncionarioRepositorio.AlterarStatusFechado(movimentoId);
            }
                catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task AdicionaDataSaida(Guid movimentoId)
        {
            try
            {
                await _entradaFuncionarioRepositorio.AdicionaDataSaida(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<int> Cadastrar(EntradaFuncionarioDTO movimentoDTO)
        {
            int retorno = 0;

            try
            {
                var pessoa = await _pessoaRepositorio.Pesquisar(movimentoDTO.PessoaId);
                var  veiculo = await _veiculoRepositorio.Pesquisar(movimentoDTO.VeiculoId);
                
                if((pessoa != null) && (veiculo != null))
                {
                    EntradaFuncionario movimento = new(movimentoDTO.Data, veiculo, pessoa);
                    retorno = await _entradaFuncionarioRepositorio.Cadastrar(movimento);
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
                await _entradaFuncionarioRepositorio.Excluir(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<EntradaFuncionario>> Listar()
        {
            try
            {
                return await _entradaFuncionarioRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EntradaFuncionario> Pesquisar(Guid movimentoId)
        {
            try
            {
                return await _entradaFuncionarioRepositorio.Pesquisar(movimentoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
