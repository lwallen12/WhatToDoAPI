using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToDoAPI.Evaluation
{
    public class EvaluationCondition
    {
        public string Name { get; set; }
        public string Preference { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string ActualValue { get; set; }
        public string EvaluationType { get; set; }
    }
}
