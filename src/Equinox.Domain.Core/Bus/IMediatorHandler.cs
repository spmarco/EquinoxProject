using Equinox.Domain.Core.Commands;
using Equinox.Domain.Core.Events;
using System.Threading.Tasks;

namespace Equinox.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        Task RaiseEvent<T>(T @event) where T : Event;
    }
}