using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Core.Entidades;

namespace Produtor.Controllers
{
    [ApiController]
    [Route("/pedido")]
    public class PedidoController : ControllerBase
    {
        private readonly IBus _bus;
        private readonly IConfiguration _configuration;

        public PedidoController(IBus bus, IConfiguration configuration)
        {
            _bus = bus;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var nomeFila = _configuration
                .GetSection("MassTransit")["NomeFila"] ?? string.Empty;
            var endponint = await _bus.GetSendEndpoint(
                new Uri($"queue:{nomeFila}")
            );

            await endponint.Send(new Pedido(1,
                new Usuario(1, "André Gama", "andre@email.com")));
            return Ok();
        }
    }
}
