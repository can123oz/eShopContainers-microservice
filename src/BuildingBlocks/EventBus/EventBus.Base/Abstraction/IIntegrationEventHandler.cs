using EventBus.Base.Events;
using System.Threading.Tasks;

namespace EventBus.Base.Abstraction
{
    public interface IIntegrationEventHandler<TIntegrationEvent> : IngtegrationEventHandler where TIntegrationEvent: IntegrationEvent
    {
       Task Handle(TIntegrationEvent @event);
    }


    public interface IngtegrationEventHandler
    {

    }
}
