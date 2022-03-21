using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class VeiculoDTO
    {
        public Guid Id { get;  set; }
        public string Placa { get;  set; }
        public string Modelo { get;  set; }

        public Veiculo ConverteVeiculo()
        {
            Veiculo veiculo = new(Id, Placa, Modelo);
            return veiculo;
        }
    }
}
