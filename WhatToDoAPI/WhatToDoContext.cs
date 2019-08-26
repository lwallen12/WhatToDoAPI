using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatToDoAPI.Models;



namespace Clash
{
    public class WhatToDoContext : DbContext
    {
        public WhatToDoContext(DbContextOptions<WhatToDoContext> options)
            : base(options)
        {
        }
        public DbSet<WhatToDoAPI.Models.Scenario> Scenario { get; set; }
        public DbSet<WhatToDoAPI.Models.UserDo> UserDo { get; set; }

        public DbSet<WhatToDoAPI.Models.WeatherCondition> WeatherCondition { get; set; }


    }
}