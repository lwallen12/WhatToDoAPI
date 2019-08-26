using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Clash;
using WhatToDoAPI.Models;

namespace WhatToDoAPI.Controllers
{
    [Route("api/weathercondition")]
    [ApiController]
    public class WeatherConditionsController : ControllerBase
    {
        private readonly WhatToDoContext _context;

        public WeatherConditionsController(WhatToDoContext context)
        {
            _context = context;
        }

        // GET: api/WeatherConditions
        [HttpGet]
        public IEnumerable<WeatherCondition> GetWeatherCondition()
        {
            return _context.WeatherCondition;
        }

        // GET: api/WeatherConditions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWeatherCondition([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var weatherCondition = await _context.WeatherCondition.FindAsync(id);

            if (weatherCondition == null)
            {
                return NotFound();
            }

            return Ok(weatherCondition);
        }


        [HttpGet("timeframe/{timeframe}")]
        public IActionResult GetWeatherByTimeFrame([FromRoute] string timeFrame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var weatherCondition =  from t in _context.WeatherCondition
            //                             where t.TimeFrame.Equals(timeFrame)
            //                             select new { weatherCondition = t.Name };

            var weatherCondition = _context.WeatherCondition.Where(s => s.TimeFrame.Equals(timeFrame));


            if (weatherCondition == null)
            {
                return NotFound();
            }

            return Ok(weatherCondition);
        }


        private bool WeatherConditionExists(int id)
        {
            return _context.WeatherCondition.Any(e => e.Id == id);
        }
    }
}