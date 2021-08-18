using BumpySellotape.Events.Controller;
using BumpySellotape.Events.Model.Conditions;
using BumpySellotape.Events.Model.Effects.Text;

namespace BumpySellotape.Events.Model.Effects
{
    public class ProcessingContext : EvaluationContext
    {
        public IEventTextManager eventTextManager;

        //public List<InteractionEventOption> eventOptions = new List<InteractionEventOption>();

        //public string eventTitle;
        //private string eventText = "";
        //public InteractionWindow interactionWindow;

        public bool isLoggingEnabled = false;
        
        public GameController GameController { get; }
        public ProcessingContext(GameController gameController)
        {
            GameController = gameController;
        }
        /*
        public string EventText
        {
            get => eventText; set
            {
                eventText = value;
                OnContextUpdated?.Invoke(this);
            }
        }

        public delegate void ContextUpdated(ProcessingContext context);
        public event ContextUpdated OnContextUpdated;

        public void AddEndEventOption()
        {
            if (eventOptions.Count == 0)
            {
                eventOptions.Add(new InteractionEventOption("Continue"));
                OnContextUpdated?.Invoke(this);
            }
        }
        */
    }
}
