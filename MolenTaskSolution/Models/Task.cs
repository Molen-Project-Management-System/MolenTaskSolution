using System;
using System.Collections.Generic;

namespace MolenTaskSolution.Models
{
    public partial class Task
    {
        public int TasksId { get; set; }
        public int? ProjectId { get; set; }
        public string? TaskName { get; set; }
        public string? Description { get; set; }
        public int? TaskOwnerId { get; set; }
        public string? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual Project? Project { get; set; }
        public virtual ProjectUser? TaskOwner { get; set; }
    }
}
