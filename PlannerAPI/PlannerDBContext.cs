using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerAPI
{
    public class PlannerDBContext:DbContext
    {
        public PlannerDBContext(DbContextOptions<PlannerDBContext> todos):base(todos) {
        }

        public DbSet<DataPlanner> DataPlanners { get; set; }

    }
}
