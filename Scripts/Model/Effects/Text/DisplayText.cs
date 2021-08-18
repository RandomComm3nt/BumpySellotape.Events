using BumpySellotape.Core.References;
using UnityEngine;

namespace BumpySellotape.Events.Model.Effects.Text
{
    public class DisplayText
    {
        [SerializeField] private ReferenceToggle<DialogueActor> dialogueActorToggle = new ReferenceToggle<DialogueActor>();
        public DialogueActor DialogueActor => dialogueActorToggle.Object;

        [field: SerializeField] public string Text { get; private set; }
    }
}
