using Sirenix.OdinInspector;

namespace Assets.Common.Scripts.Data.Characters.Traits
{
    public abstract class TraitBase : SerializedScriptableObject
    {
        public abstract TraitValueType TraitValueType { get; }
    }
}
