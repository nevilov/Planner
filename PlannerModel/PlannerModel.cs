using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerModel
{
    public class PlannerModel
    {
        public string Id { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime startTodo { get; set; }

        public DateTime dueTodo { get; set; }

        public bool Completed { get; set; }
    }
}
