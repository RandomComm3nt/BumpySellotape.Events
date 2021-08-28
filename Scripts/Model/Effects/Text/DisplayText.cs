using BumpySellotape.Core.References;
using Sirenix.OdinInspector;
using UnityEngine;

namespace BumpySellotape.Events.Model.Effects.Text
{
    [HideReferenceObjectPicker]
    public class DisplayText
    {
        [SerializeField] private ReferenceToggle<DialogueActor> dialogueActorToggle = new ReferenceToggle<DialogueActor>();
        public DialogueActor DialogueActor => dialogueActorToggle.Object;

        [field: SerializeField] public string Text { get; private set; }
    }
}
