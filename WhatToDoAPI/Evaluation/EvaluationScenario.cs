using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatToDoAPI.Evaluation;

namespace WhatToDoAPI.DataAccess
{
    public class EvaluationScenario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserDoId { get; set; }

       // public List<EvaluationCondition> EvaluationConditions { get; set; }

    }
}
