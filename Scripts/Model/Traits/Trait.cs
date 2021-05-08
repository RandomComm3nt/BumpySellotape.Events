using Assets.Common.Scripts.Data.Characters;
using Assets.Common.Scripts.Data.Characters.Traits;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Common.Scripts.Data
{
    [CreateAssetMenu(menuName = "Common/Trait")]
    public class Trait : TraitBase
    {
        [SerializeField] private TraitValueType traitValueType = TraitValueType.Flag;
        [SerializeField] private bool hidden = false;
        [SerializeField] [HideIf("hidden")] private string traitName = "";
        [SerializeField] [HideIf("hidden")] [Multiline(2)] private string description = "";
        [SerializeField] private List<TraitStatModifier> statModifiers = new List<TraitStatModifier>();
        [SerializeField] [ShowIf("traitValueType", TraitValueType.Stack)] private int maxStacks = 100;

        public override TraitValueType TraitValueType => traitValueType;

        public bool Hidden => hidden;
        public string TraitName => traitName.IsNullOrWhitespace() ? name : traitName;
        public string Description => description;
        public List<TraitStatModifier> StatModifiers => statModifiers;
        public int MaxStacks => maxStacks;
    }
}
