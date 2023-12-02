
using Core.Entidades;
using MassTransit;

namespace Consumidor.Events
{
    public class PedidoCriadoConsumidor : IConsumer<Pedido>
    {
        public Task Consume(ConsumeContext<Pedido> context)
        {
            Console.WriteLine(context.Message);
            return Task.CompletedTask;
        }
    }
}
