using System;
using System.Collections.Generic;

namespace MolenTaskSolution.Models
{
    public partial class Project
    {
        public Project()
        {
            FileAttachments = new HashSet<FileAttachment>();
            Tasks = new HashSet<Task>();
        }

        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        public int? ProjectOwnerId { get; set; }
        public string? Status { get; set; }
        public byte[]? Document { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual User? ProjectOwner { get; set; }
        public virtual ICollection<FileAttachment> FileAttachments { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
