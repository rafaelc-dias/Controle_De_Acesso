using ControleAcesso.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private static List<Veiculos> ListaVeiculos = new();

        [HttpGet]
        public async Task<IActionResult> RetonarVeiculos()
        {
            return Ok(ListaVeiculos);
        }

        [HttpGet("{placa}")]
        public async Task<IActionResult> RetonarVeiculos(string placa)
        {
            var veiculo = ListaVeiculos.Find(placaResultado => placaResultado.Placa == placa);

            if (veiculo == null)
                return BadRequest("Pessoa não encontrada");
            return Ok(veiculo);
        }

        [HttpPost]
        public async Task<IActionResult> AdiconarVeiculos(Veiculos veiculo)
        {
            ListaVeiculos.Add(veiculo);
            return Ok(ListaVeiculos);
        }

        [HttpPut]
        public async Task<IActionResult> AlterarVeiculos(Veiculos veiculoProcurado)
        {
            var veiculo = ListaVeiculos.Find(veiculoResultado => veiculoResultado.Placa == veiculoProcurado.Placa);

            if (veiculo == null)
                return BadRequest("Pessoa não encontrada");

            veiculo.AlterarModeloVeiculo(veiculoProcurado.Modelo);

            return Ok(veiculo);
        }

        [HttpDelete("{placa}")]
        public async Task<IActionResult> RemoverVeiculos(string placa)
        {
            var veiculo = ListaVeiculos.Find(veiculoResultado => veiculoResultado.Placa == placa);

            if (veiculo == null)
                return BadRequest("Pessoa não encontrada");
            ListaVeiculos.Remove(veiculo);
            return Ok(veiculo);
        }
    }
}
