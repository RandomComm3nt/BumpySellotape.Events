using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Common.Scripts.Data.Characters.Traits
{
    [CreateAssetMenu(menuName = "Common/Trait Family")]
    public class TraitFamily : TraitBase
    {
        [SerializeField] private Dictionary<Trait, int> traits = new Dictionary<Trait, int>();
        [SerializeField] private bool determineFromOtherTraits = false;
        [SerializeField][ShowIf("determineFromOtherTraits")] private Dictionary<Trait, int> sourceTraits = new Dictionary<Trait, int>();

        public override TraitValueType TraitValueType => TraitValueType.Value;
    }
}
