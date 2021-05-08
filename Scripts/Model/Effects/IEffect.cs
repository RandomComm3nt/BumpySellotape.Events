using BumpySellotape.Events.Model.Conditions;

namespace BumpySellotape.Events.Model.Effects
{
    public interface IEffect
    {
        void Activate(EvaluationContext evaluationContext);

        string Label { get; }
    }
}

