using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cruzen.Models;

namespace Cruzen.Data
{
    public class CruiseDBContext : DbContext
    {
        public CruiseDBContext(DbContextOptions<CruiseDBContext> options)
            : base(options)
        { }


        public DbSet<Cruise> Cruise { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<State> States { get; set; }
        //public DbSet<Type> Type { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
