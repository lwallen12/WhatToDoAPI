using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToDoAPI.Models
{
    public class Scenario
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string UserScenarioName { get; set; }
        public string Description { get; set; }
        public int? ScoreLevel { get; set; }
        public int? NotifyLevel { get; set; }
        public string ConditionFiveName { get; set; }
        public string ConditionFourName { get; set; }
        public string ConditionThreeName { get; set; }
        public string ConditionTwoName { get; set; }
        public string ConditionOneName { get; set; }
        public string ConditionFiveType { get; set; }
        public string ConditionFourType { get; set; }
        public string ConditionThreeType { get; set; }
        public string ConditionTwoType { get; set; }
        public string ConditionOneType { get; set; }
        public int? ConditionFiveId { get; set; }
        public int? ConditionFourId { get; set; }
        public int? ConditionThreeId { get; set; }
        public int? ConditionTwoId { get; set; }
        public int? ConditionOneId { get; set; }
        public string BlockingThreeName { get; set; }
        public string BlockingTwoName { get; set; }
        public string BlockingOneName { get; set; }
        public string BlockingThreeType { get; set; }
        public string BlockingTwoType { get; set; }
        public string BlockingOneType { get; set; }
        public int? BlockingThreeId { get; set; }
        public int? BlockingTwoId { get; set; }
        public int? BlockingOneId { get; set; }
        public int? ConditionFiveRank { get; set; }
        public int? ConditionFourRank { get; set; }
        public int? ConditionThreeRank { get; set; }
        public int? ConditionTwoRank { get; set; }
        public int? ConditionOneRank { get; set; }
        public string ConditionFivePreference { get; set; }
        public string ConditionFourPreference { get; set; }
        public string ConditionThreePreference { get; set; }
        public string ConditionTwoPreference { get; set; }
        public string ConditionOnePreference { get; set; }
        public string BlockingThreePreference { get; set; }
        public string BlockingTwoPreference { get; set; }
        public string BlockingOnePreference { get; set; }
        public int? LocationId { get; set; }

        public string UserDoId { get; set; }


        /*
        [ForeignKey("UserDoId")]
        public UserDo UserDo { get; set; }*/

    }
}
