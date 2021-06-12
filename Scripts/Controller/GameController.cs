using BumpySellotape.Events.Model.Nodes;
using BumpySellotape.Events.View;
using UnityEngine;

namespace BumpySellotape.Events.Controller
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private EventNode rootNode = default;
        [field: SerializeField] public ScreenManager ScreenManager { get; private set; }

        public void Start()
        {
            rootNode.Process(new Model.Effects.ProcessingContext(this));
        }
    }
}
