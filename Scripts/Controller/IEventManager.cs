using BumpySellotape.Events.Model.Effects;
using BumpySellotape.Events.Model.Nodes;

namespace Events.Controller
{
    public interface IEventManager
    {
        ProcessingContext CreateProcessingContext();
        void ProcessEventNode(EventNode eventNode);
    }
}
