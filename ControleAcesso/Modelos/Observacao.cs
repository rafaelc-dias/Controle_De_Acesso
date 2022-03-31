namespace ControleAcesso.Domain.Modelos
{
    public class Observacao
    {
        public Guid Id { get; private set; }
        public Guid? EntradaFuncionarioId { get; private set; } = null;
        public Guid? MovimentoPesagemId { get; private set; } = null;
        public Guid?  SaidaCarroEmpresaId { get; private set; } = null;
        public string Obs { get; private set; }

        public void AdicionaObservacaoEntradaFuncionario(string obs, Guid entradaFuncionarioId)
        {
            Id = Guid.NewGuid();
            Obs = obs;
            EntradaFuncionarioId = entradaFuncionarioId;
            
        }

        public void AdicionaObservacaoMovimentoPesagem(string obs, Guid movimentoPesagemId)
        {
            Id = Guid.NewGuid();
            Obs = obs;
            MovimentoPesagemId = movimentoPesagemId;
        }

        public void AdicionaObservacaoSaidaCarroEmpresa(string obs, Guid saidaCarroEmpresaId)
        {
            Id = Guid.NewGuid();
            Obs = obs;
            SaidaCarroEmpresaId = saidaCarroEmpresaId;
        }

    }


}
