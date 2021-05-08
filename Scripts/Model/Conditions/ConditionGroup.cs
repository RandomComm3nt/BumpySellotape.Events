﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BumpySellotape.Events.Model.Conditions
{
    public class ConditionGroup : ICondition
    {
        private enum GroupType
        {
            And = 0,
            Or
        }

        [SerializeField] private GroupType groupType = GroupType.And;
        [SerializeField] private List<ICondition> criteria = new List<ICondition>();

        public string Label => $"Group";

        public bool Evaluate(EvaluationContext evaluationContext)
        {
            return (groupType == GroupType.And)
                ? criteria.All(c => c.Evaluate(evaluationContext))
                : criteria.Any(c => c.Evaluate(evaluationContext));
        }
    }
}
