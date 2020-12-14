using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Planner.Model
{
    public class PlannerModel
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime startTodo { get; set; }

        public DateTime dueTodo { get; set; }

        public bool Completed { get; set; }
    }
}
