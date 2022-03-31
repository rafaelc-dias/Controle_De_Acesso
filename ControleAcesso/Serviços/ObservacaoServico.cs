using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Domain.Modelos;

namespace ControleAcesso.Domain.Serviços
{
    public class ObservacaoServico //: IObservacaoSerivco
    {
        public readonly IObservacaoRepositorio _observacaoRepositorio;

        public ObservacaoServico(IObservacaoRepositorio observacaoRepositorio)
        {
            _observacaoRepositorio = observacaoRepositorio; 
        }
        

        /*public async Task<bool> Cadastrar(ObservacaoDTO observacaoDTO)
        {
            bool resposta = false;
            
            if (observacaoDTO != null)
            {
                try
                {
                    if (await _observacaoRepositorio.Cadastrar(observacaoDTO.ConverteObservacao()) != null)
                    {
                        resposta = true;    
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            return resposta;
        }
       

        public async Task<List<Observacao>> Listar()
        {
            try
            {
                return await _observacaoRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Observacao>> ListarObservacoesMovimento(Guid movimentoID)
        {
            try
            {
                return await _observacaoRepositorio.ListarObservacoesMovimento(movimentoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Observacao> Pesquisar(Guid observacaoID)
        {
            try
            {
                return await _observacaoRepositorio.Pesquisar(observacaoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
