using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerAPI
{
    public class DataPlanner
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime startTodo { get; set; }

        public DateTime dueTodo { get; set; }

        public bool Completed { get; set; }
    }
}
