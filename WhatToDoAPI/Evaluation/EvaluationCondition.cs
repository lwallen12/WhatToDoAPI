using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToDoAPI.Evaluation
{
    public class Condition
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string Preference { get; set; }
        public string CurrentStatus { get; set; }
        public string EvalType { get; set; }
        public int? Rank { get; set; }
        public string TimeFrame { get; set; }
        public DateTime ConditionDateTime { get; set; }


        //TODO: Method for evaluating whether the Preference was met


            //I actually am starting to think that this should be a string return like... "Met" or "Failed"
        public int Evaluate()
        {
            if (this.EvalType == "Range")
            {
                string[] strPreferenceRange = this.Preference.Split(",");

                int intCurrentStatus = Convert.ToInt32(this.CurrentStatus);

                int intMin = Convert.ToInt32(strPreferenceRange[0]);
                int intMax = Convert.ToInt32(strPreferenceRange[1]);

                if (Enumerable.Range(intMin, intMax).Contains(intCurrentStatus))
                {
                    return this.Rank;
                }

                else
                {
                    return 0;
                }
            }

            else if (this.EvalType == "Equality")
            {
                if (this.CurrentStatus == this.Preference)
                {
                    return this.Rank;
                }

                else
                {
                    return 0;
                }
            }

            else
            {
                throw new NotImplementedException();
            }
        }

    }
}
