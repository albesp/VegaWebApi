﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega_WebApi.Models;

namespace Vega_WebApi.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
             : base(options)
        {
        
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

    }
}
