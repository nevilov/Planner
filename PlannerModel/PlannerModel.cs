using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerModel
{
    class PlannerModel
    {
        string Id { get; set; }

        string Title { get; set; }

        string Description { get; set; }

        DateTime startTodo { get; set; }

        DateTime dueTodo { get; set; }

        bool Completed { get; set; }
    }
}
