namespace BumpySellotape.Events.Model.Conditions
{
    public interface ICondition
    {
        bool Evaluate(EvaluationContext evaluationContext);

        string Label { get; }
    }
}
