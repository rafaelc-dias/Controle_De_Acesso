using ControleAcesso.Class;

namespace ControleAcesso.Domain.DTO
{
    public class VeiculosDTO
    {
        public Guid Id { get;  set; }
        public string Placa { get;  set; }
        public string Modelo { get;  set; }

        public Veiculos ConverteVeiculo()
        {
            Veiculos veiculo = new(Id, Placa, Modelo);
            return veiculo;
        }
    }
}
