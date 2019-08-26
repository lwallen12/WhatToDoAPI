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
        public IActionResult GetEvaluation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //List<T> conditionsList = new List<T>();

            var conditionNameList = (from sc in _context.Scenario
                                             where sc.Id == id
                                             select new
                                             {
                                                 ConditionFiveName = sc.ConditionFiveName,
                                                 ConditionFourName = sc.ConditionFourName,
                                                 ConditionThreeName = sc.ConditionThreeName,
                                                 ConditionTwoName = sc.ConditionTwoName,
                                                 ConditionOneName = sc.ConditionOneName
                                             });
            var conditionPreferenceList = (from sc in _context.Scenario
                                           where sc.Id == id
                                           select new
                                           {
                                               ConditionFivePreference = sc.ConditionFivePreference,
                                               ConditionFourPreference = sc.ConditionFourPreference,
                                               ConditionThreePreference = sc.ConditionThreePreference,
                                               ConditionTwoPreference = sc.ConditionTwoPreference,
                                               ConditionOnePreference = sc.ConditionOnePreference
                                           });
            var conditionTypeList = (from sc in _context.Scenario
                                           where sc.Id == id
                                           select new
                                           {
                                               ConditionFiveType = sc.ConditionFiveType,
                                               ConditionFourType = sc.ConditionFourType,
                                               ConditionThreeType = sc.ConditionThreeType,
                                               ConditionTwoType = sc.ConditionTwoType,
                                               ConditionOneType = sc.ConditionOneType
                                           });
            var conditionRankList = (from sc in _context.Scenario
                                        where sc.Id == id
                                        select new
                                        {
                                            ConditionFiveRank = sc.ConditionFiveRank,
                                            ConditionFourRank = sc.ConditionFourRank,
                                            ConditionThreeRank = sc.ConditionThreeRank,
                                            ConditionTwoRank = sc.ConditionTwoRank,
                                            ConditionOneRank = sc.ConditionOneRank
                                        });

            
            string connStr = "server=test1.ce8cn9mhhgds.us-east-1.rds.amazonaws.com;user=Wallen;database=whattodo;port=3306;password=MyRDSdb1";
            MySqlConnection conn = new MySqlConnection(connStr);


            conn.Open();

            List <EvaluationCondition> EvaluationConditions = new List<EvaluationCondition>();

            int x = 0;
            while (x < 40)
            {
                
            }


            

            


            return Ok();
        }


    }
}