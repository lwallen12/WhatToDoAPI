using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Clash;
using WhatToDoAPI.Models;
using WhatToDoAPI.Evaluation;
using MySql.Data.MySqlClient;

namespace WhatToDoAPI.Controllers
{
    [Route("api/evaluations/")]
    [ApiController]
    public class EvaluationsController : ControllerBase
    {
        private readonly WhatToDoContext _context;

        public EvaluationsController(WhatToDoContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvaluation([FromRoute] int id)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            

            Scenario selectedScenario = await _context.Scenario.FindAsync(id);


            List<string> conditionNames = new List<string>();

            conditionNames.Add(selectedScenario.ConditionFiveName);
            conditionNames.Add(selectedScenario.ConditionFourName);
            conditionNames.Add(selectedScenario.ConditionThreeName);
            conditionNames.Add(selectedScenario.ConditionTwoName);
            conditionNames.Add(selectedScenario.ConditionOneName);


            List<string> conditionTypes = new List<string>();

            conditionTypes.Add(selectedScenario.ConditionFiveType);
            conditionTypes.Add(selectedScenario.ConditionFourType);
            conditionTypes.Add(selectedScenario.ConditionThreeType);
            conditionTypes.Add(selectedScenario.ConditionTwoType);
            conditionTypes.Add(selectedScenario.ConditionOneType);


            List<string> conditionPreferences = new List<string>();

            conditionPreferences.Add(selectedScenario.ConditionFivePreference);
            conditionPreferences.Add(selectedScenario.ConditionFourPreference);
            conditionPreferences.Add(selectedScenario.ConditionThreePreference);
            conditionPreferences.Add(selectedScenario.ConditionTwoPreference);
            conditionPreferences.Add(selectedScenario.ConditionOnePreference);

            List<int?> conditionRanks = new List<int?>();

            conditionRanks.Add(selectedScenario.ConditionFiveRank);
            conditionRanks.Add(selectedScenario.ConditionFourRank);
            conditionRanks.Add(selectedScenario.ConditionThreeRank);
            conditionRanks.Add(selectedScenario.ConditionTwoRank);
            conditionRanks.Add(selectedScenario.ConditionOneRank);

            int? scenarioLocationId = selectedScenario.LocationId;

            List<WeatherCondition> weatherConditions = _context.WeatherCondition.Where(x => x.LocationId == scenarioLocationId).ToList<WeatherCondition>();

            //This is what I want to ultimately return
            List<Condition> conditions = new List<Condition>();

            foreach (WeatherCondition c in weatherConditions)
            {
                Condition currentConditionFive = new Condition();
                Condition currentConditionFour = new Condition();
                Condition currentConditionThree = new Condition();
                Condition currentConditionTwo = new Condition();
                Condition currentConditionOne = new Condition();

                currentConditionFive.Name = conditionNames[0];
                currentConditionFour.Name = conditionNames[1];
                currentConditionThree.Name = conditionNames[2];
                currentConditionTwo.Name = conditionNames[3];
                currentConditionOne.Name = conditionNames[4];

                currentConditionFive.Preference = conditionPreferences[0];
                currentConditionFour.Preference = conditionPreferences[1];
                currentConditionThree.Preference = conditionPreferences[2];
                currentConditionTwo.Preference = conditionPreferences[3];
                currentConditionOne.Preference = conditionPreferences[4];

                currentConditionFive.Rank = conditionRanks[0];
                currentConditionFour.Rank = conditionRanks[1];
                currentConditionThree.Rank = conditionRanks[2];
                currentConditionTwo.Rank = conditionRanks[3];
                currentConditionOne.Rank = conditionRanks[4];

                string strName = _context.WeatherCondition.//.Where(x => x.Equals())
               


            }

            int i = 0;
            while (i <= 320)
            {

            }
            



            


            return Ok(weatherConditions);
        }


    }
}