using UnityEngine;

namespace BumpySellotape.Events.Model.Nodes
{
    public class EventTrigger
    {
        [field: SerializeField] public EventNode EventNode { get; private set; }
    }
}
